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
        private Dialogue _currentDialogue;
        private const int MOVE_ID = 1;
        private const int LOOK_ID = 2;
        private const int USE_ID = 3;
        private const int TALK_ID = 4;
        private int menu_ID = 0;

        public Skeletown_Game()
        {
            InitializeComponent();
             _player = new Player("Sam");
            _player.Inventory.Add(new InventoryItem(
                World.ItemByID(World.ITEM_ID_GUN), 1));
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
        }

        private void listMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Moving menu
            if (menu_ID == MOVE_ID)
            {
                MoveTo((Location)listMenu.SelectedItem);
                menu_ID = 0;
            }

            // Talking menu
            else if (menu_ID == TALK_ID)
            {
                bool dialogueCheck = DisplayDialogue(Convert.ToDouble(listMenu.SelectedValue.ToString()));
                
                // End of dialogue reached
                if (!dialogueCheck)
                {
                    menu_ID = 0;
                }
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            menu_ID = 0;
            // Adding possible locations, and new locations
            List<Location> moveOptions = _player.VisitedLocations.Union(_player.CurrentLocation.AdjacentLocations).ToList();
            moveOptions.Remove(_player.CurrentLocation);

            // Changing the menu to be based on moveOptions
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

        private void btnTalk_Click(object sender, EventArgs e)
        {
            menu_ID = 0;
            // If an NPC exists here
            if (_currentNPC != null)
            {
                menu_ID = TALK_ID;
                listMenu.Visible = true;

                // NPC Dialogue
                DisplayDialogue(0.0);
            }
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
            lblLocation.Text = newLocation.Name;

            // Does the location have a NPC?
            _currentNPC = null;
            if (newLocation.NPCHere != null)
            {
                _currentNPC = newLocation.NPCHere;
            }

            // Refresh player's inventory list
            UpdateInventoryListInUI();
            // Refresh player's quest list
            UpdateQuestListInUI();
        }

        private bool DisplayDialogue(double responseID)
        {
            menu_ID = 0;

            if (_currentNPC != null)
            {
                // Changing the dialogue in response to previous dialogue
                // Finding dialogue
                _currentDialogue = World.DialogueByID(_currentNPC, responseID);

                // Dialogue exists
                if (_currentDialogue != null)
                {
                    rtbMessages.Text = _currentDialogue.NPCDialogue;

                    // Giving user dialogue responses
                    listMenu.DataSource = new BindingSource(_currentDialogue.responseDictionary(), null);
                    listMenu.DisplayMember = "Value";
                    listMenu.ValueMember = "Key";
                    listMenu.Visible = true;
                    menu_ID = TALK_ID;
                }

                // No dialogue exists, meaning end of conversation
                else
                {
                    DisplayDialogue(0.0);
                }

                return true;
            }

            return false;

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
