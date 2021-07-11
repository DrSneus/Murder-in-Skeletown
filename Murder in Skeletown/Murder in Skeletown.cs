using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skeletown_Game
{
    public partial class Skeletown_Game : Form
    {
        private Player _player;
        private NPC _currentNPC;
        private const int MOVE_ID = 1;
        private const int LOOK_ID = 2;
        private const int GIVE_ID = 3;
        private const int TALK_ID = 4;
        private int menu_ID = 0;

        public Skeletown_Game()
        {
            InitializeComponent();
             _player = new Player("Sam");
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            _player.Inventory.Add(new InventoryItem(
                World.ItemByID(World.ITEM_ID_GUN), 1));
        }

        private void listMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu_ID == MOVE_ID)
            {
                MoveTo((Location)listMenu.SelectedItem);
                menu_ID = 0;
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            List<Location> moveOptions = _player.VisitedLocations.Union(_player.CurrentLocation.AdjacentLocations).ToList();
            moveOptions.Remove(_player.CurrentLocation);

            listMenu.DataSource = moveOptions;
            listMenu.DisplayMember = "Name";

            menu_ID = MOVE_ID;
            listMenu.Visible = true;
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            menu_ID = LOOK_ID;
            rtbMessages.Text = _player.CurrentLocation.Description;
            listMenu.Visible = false;
        }

        private void MoveTo(Location newLocation)
        {
            // Is the area available to enter?
            if (newLocation.IsLocked)
            {
                return;
            }
            // Mark location as having been entered
            _player.IsNewLocation(newLocation);

            // Update the player's current location
            _player.CurrentLocation = newLocation;
            
            // Clear text
            rtbMessages.Text = "";
            listMenu.Visible = false;

            // Display current location name and description
            lblLocation.Text = newLocation.Name + Environment.NewLine;

            // Does the location have a quest?
            if (newLocation.QuestAvailableHere != null)
            {
                // See if the player already has the quest, and if they've completed it
                bool playerAlreadyHasQuest = _player.HasThisQuest(newLocation.QuestAvailableHere);
                if (playerAlreadyHasQuest)
                {
                    // See if the player has completed the quest
                    bool playerAlreadyCompletedQuest = _player.CompletedThisQuest(newLocation.QuestAvailableHere);

                    // If the player has not completed the quest yet
                    if (!playerAlreadyCompletedQuest)
                    {
                        // See if the player has all the items needed to complete the quest
                        bool playerHasAllItemsToCompleteQuest = _player.HasAllQuestCompletionItems(newLocation.QuestAvailableHere);

                        // The player has all items required to complete the quest
                        if (playerHasAllItemsToCompleteQuest)
                        {
                            // Display message
                            rtbMessages.Text = "You've completed the \"" +
                                newLocation.QuestAvailableHere.Name +
                                    "\" quest." + Environment.NewLine;

                            // Remove quest items from inventory
                            _player.RemoveQuestCompletionItems(newLocation.QuestAvailableHere);

                            // Give quest rewards
                            if (newLocation.QuestAvailableHere.RewardItem != null)
                            {
                                rtbMessages.Text += "You receive: " + Environment.NewLine;
                                rtbMessages.Text +=
                                    newLocation.QuestAvailableHere.RewardItem.Name +
                                        Environment.NewLine;
                                rtbMessages.Text += Environment.NewLine;

                                // Add the reward item to the player's inventory
                                _player.AddItemToInventory(newLocation.QuestAvailableHere.RewardItem);
                            }

                            // Mark the quest as completed
                            _player.MarkQuestCompleted(newLocation.QuestAvailableHere);
                        }
                    }
                }

                // The player does not already have the quest
                else
                {
                    // Display the messages
                    rtbMessages.Text += "You received the quest: \"" +
                        newLocation.QuestAvailableHere.Name + "\""+ Environment.NewLine;

                    rtbMessages.Text += newLocation.QuestAvailableHere.Description +
                        Environment.NewLine;

                    // Add the quest to the player's quest list
                    _player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere));
                }
            }

            // Does the location have a NPC?
            _currentNPC = null;
            if (newLocation.NPCHere != null)
            {
                rtbMessages.Text += "You see a " + newLocation.NPCHere.Name +
                    Environment.NewLine;

                // Make a new NPC, using the values from the standard NPC
                // in the World.NPC list
                NPC standardNPC = World.NPCByID(
                    newLocation.NPCHere.ID);

                _currentNPC = new NPC(standardNPC.ID, standardNPC.Name);
            }

            // Refresh player's inventory list
            UpdateInventoryListInUI();
            // Refresh player's quest list
            UpdateQuestListInUI();
        }

        private void UpdateInventoryListInUI()
        {
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Name";
            dgvInventory.Columns[0].Width = 197;
            dgvInventory.Columns[1].Name = "Quantity";
            dgvInventory.Rows.Clear();
            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    dgvInventory.Rows.Add(new[] {
                        inventoryItem.Details.Name,
                        inventoryItem.Quantity.ToString() });
                }
            }
        }
        private void UpdateQuestListInUI()
        {
            dgvQuests.RowHeadersVisible = false;
            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Name";
            dgvQuests.Columns[0].Width = 197;
            dgvQuests.Columns[1].Name = "Done?";
            dgvQuests.Rows.Clear();
            foreach (PlayerQuest playerQuest in _player.Quests)
            {
                dgvQuests.Rows.Add(new[] {
                    playerQuest.Details.Name,
                    playerQuest.IsCompleted.ToString() });
            }
        }

    }
}
