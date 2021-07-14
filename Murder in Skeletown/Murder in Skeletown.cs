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
        private const int DIALOGUE_ID = 1;
        private const int MOVE_ID = 3;
        private int menu_ID = 0;

        public Skeletown_Game()
        {
            InitializeComponent();
             _player = new Player("UserName");
            _player.Inventory.Add(World.ItemByID(World.ITEM_ID_NEWS));
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
        }

        private void listMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Moving menu
            if (menu_ID == MOVE_ID)
            {
                menu_ID = 0;
                MoveTo((Location)listMenu.SelectedItem);
            }

            // Dialogue menu: Either talking or inspecting environment
            else if (menu_ID == DIALOGUE_ID)
            {
                bool dialogueCheck = DisplayDialogue(Convert.ToDouble(listMenu.SelectedValue.ToString()));
                
                // End of dialogue reached
                if (!dialogueCheck)
                {
                    DisplayDialogue(0);
                }
            }
        }

        private void btnDialogue_Click(object sender, EventArgs e)
        {
            menu_ID = DIALOGUE_ID;
            DisplayDialogue(0);
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

            // Display current location name and description
            lblLocation.Text = newLocation.Name;

            // Does the location have a NPC?
            _currentNPC = newLocation.NPCHere;
            SetUpNPC(_currentNPC);
            SwapDialogueButton();

            // Set up dialogue
            DisplayDialogue(0);

            // Refresh player's inventory list
            UpdateInventoryListInUI();
            UpdateClueListInUI();
        }

        private void SetUpNPC(NPC npcCheck)
        {
            // NPC
            if (npcCheck != null)
            {
                pbNPC.Visible = true;
                pbNPC.Image = (Image)Properties.Resources.ResourceManager.GetObject(_currentNPC.Name, Properties.Resources.Culture);
                rtbMessages.Location = new Point(118, 512);
                rtbMessages.Size = new Size(608, 101);
            }

            // No NPC
            else
            {
                pbNPC.Visible = false;
                rtbMessages.Location = new Point(12, 512);
                rtbMessages.Size = new Size(714, 101);
            }

        }

        private bool DisplayDialogue(double responseID)
        {
            menu_ID = 0;

            // NPC here, so initiate dialogue with them
            if (_currentNPC != null)
            {
                // Changing the dialogue in response to previous dialogue
                // Finding dialogue
                _currentDialogue = World.NPCDialogueByID(_currentNPC, responseID);

                // Dialogue exists
                if (_currentDialogue != null)
                {
                    rtbMessages.Text = _currentDialogue.ToUserDialogue;

                    // Giving user dialogue responses
                    listMenu.DataSource = new BindingSource(_currentDialogue.responseDictionary(), null);
                    listMenu.DisplayMember = "Value";
                    listMenu.ValueMember = "Key";
                    listMenu.Visible = true;
                    menu_ID = DIALOGUE_ID;

                    // Checking for clues
                    _player.checkForClues(_currentDialogue);
                    UpdateClueListInUI();

                    return true;
                }

                // No dialogue exists, meaning end of conversation
                else
                {
                    DisplayDialogue(0.0);
                }
            }

            // No NPC, use Location dialogue instead
            else
            {
                // Changing the dialogue in response to previous dialogue
                // Finding dialogue
                _currentDialogue = World.LocationDialogueByID(_player.CurrentLocation, responseID);

                // Dialogue exists
                if (_currentDialogue != null)
                {
                    rtbMessages.Text = _currentDialogue.ToUserDialogue;

                    // Giving user dialogue responses
                    listMenu.DataSource = new BindingSource(_currentDialogue.responseDictionary(), null);
                    listMenu.DisplayMember = "Value";
                    listMenu.ValueMember = "Key";
                    listMenu.Visible = true;
                    menu_ID = DIALOGUE_ID;

                    // Checking for clues
                    _player.checkForClues(_currentDialogue);
                    UpdateClueListInUI();

                    return true;
                }

                // No dialogue exists, meaning end of conversation
                else
                {
                    DisplayDialogue(0.0);
                }

            }

            return false;
        }

        private void UpdateInventoryListInUI()
        {
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.ColumnCount = 1;
            dgvInventory.Columns[0].Width = 540;
            dgvInventory.Rows.Clear();
            foreach (Item i in _player.Inventory)
            {
                dgvInventory.Rows.Add(new[] {
                    i.Name + ": " + i.Description });
            }
        }

        private void UpdateClueListInUI()
        {
            dgvClues.RowHeadersVisible = false;
            dgvClues.ColumnCount = 1;
            dgvClues.Columns[0].Width = 540;
            dgvClues.Rows.Clear();
            foreach (Clue pClue in _player.Clues)
            {
                dgvClues.Rows.Add(new[] {
                    pClue.Name});
            }
        }

        private void SwapDialogueButton()
        {
            btnDialogue.Text = "Look";

            if(_currentNPC != null)
            {
                btnDialogue.Text = "Talk";
            }
        }
    }
}
