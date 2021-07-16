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
        private DialogueFlag _currentFlag;
        private const int DIALOGUE_ID = 1;
        private const int MOVE_ID = 2;
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
            // Adding all adjacent, unlocked locations
            List<Location> moveOptions = new List<Location>();
            foreach(Location adjacent in _player.CurrentLocation.AdjacentLocations)
            {
                if (!adjacent.IsLocked)
                {
                    moveOptions.Add(adjacent);
                }
            }

            // Changing the menu to be based on moveOptions
            listMenu.DataSource = moveOptions;
            listMenu.DisplayMember = "Name";
            menu_ID = MOVE_ID;
        }

        private void MoveTo(Location newLocation)
        {
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
            _currentFlag = null;
            DisplayDialogue(0);
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
                _currentDialogue = World.NPCDialogueByID(_currentNPC, responseID);

            }

            // No NPC, use location dialogue instead
            else
            {
                _currentDialogue = World.LocationDialogueByID(_player.CurrentLocation, responseID);
            }

            // No dialogue exists, so end conversation
            if (_currentDialogue == null)
            {
                DisplayDialogue(0.0);
                return false;
            }

            // Check the dialogue flag at the location, if there is one
            if (_currentNPC != null)
            {
                _currentFlag = _currentNPC.Flag;
            }

            else {
                _currentFlag = _player.CurrentLocation.Flag;
            }

            // If we have the clues and items necessary to complete the flag, then add the new dialogue
            if (_player.IsFlagCompleted(_currentFlag))
            {
                AddNewDialogue();
            }

            // Remove flag and unlock locations once the dialogue has been selected
            else if(_currentFlag != null && _currentDialogue.ID == _currentFlag.NewDialogue.ID){
                World.ClueByID(_currentFlag.ClueReq.ID).ReplaceDialogue();
                
                _currentFlag = null;

                if(_currentNPC != null)
                {
                    _currentNPC.Flag = null;
                }
                else
                {
                    _player.CurrentLocation.Flag = null;
                }

                _player.CurrentLocation.UnlockAdjacentLocations(_currentFlag);
            }

            // Display text to user
            rtbMessages.Text = _currentDialogue.ToUserDialogue;

            // Giving user dialogue responses
            listMenu.DataSource = new BindingSource(_currentDialogue.responseDictionary(), null);
            listMenu.DisplayMember = "Value";
            listMenu.ValueMember = "Key";
            listMenu.Visible = true;
            menu_ID = DIALOGUE_ID;

            // If an item exists at this dialogue, add to inventory
            if (_player.checkForItems(_currentDialogue))
            {
                btnInventory_Click();
            }

            // If a clue exists at this dialogue, add to inventory
            if (_player.checkForClues(_currentDialogue))
            {
                btnClues_Click();
            }

            // Updates
            UpdateDGV();

            return true;
        }

        private void AddNewDialogue()
        {
            // If NPC Dialogue
            if (_currentNPC != null)
            {             
                // Adds a new response to a specific dialogue
                Dialogue AddDialogue = World.NPCDialogueByID(_currentNPC, _currentFlag.NewDialoguePath);
                AddDialogue.AddNewResponse(_currentFlag.NewResponse, _currentFlag.NewDialogue.ID);

                // Adds the full dialogue into the dialogue tree
                _currentNPC.DialogueTree.Add(_currentFlag.NewDialogue);
            }

            // If Location Dialogue
            else
            {             
                // Adds a new response to a specific dialogue
                Dialogue AddDialogue = World.LocationDialogueByID(_player.CurrentLocation, _currentFlag.NewDialoguePath);
                AddDialogue.AddNewResponse(_currentFlag.NewResponse, _currentFlag.NewDialogue.ID);

                // Adds the full dialogue into the dialogue tree
                _player.CurrentLocation.DialogueTree.Add(_currentFlag.NewDialogue);
            }

            // Sets the flag as invalid, meaning its dialogue won't be readded
            _currentFlag.NewDialoguePath = 0;
        }

        private void UpdateInventoryListInUI()
        {
            dgvData.RowHeadersVisible = false;
            dgvData.ColumnCount = 2;
            dgvData.Columns[0].Width = 200;
            dgvData.Columns[1].Width = 330;
            dgvData.Rows.Clear();
            _player.Inventory.Reverse();
            foreach (Item i in _player.Inventory)
            {
                dgvData.Rows.Add(new[] {
                    i.Name, i.Description});
            }
            _player.Inventory.Reverse();
        }

        private void UpdateClueListInUI()
        {
            dgvData.RowHeadersVisible = false;
            dgvData.ColumnCount = 2;
            dgvData.Columns[0].Width = 200;
            dgvData.Columns[1].Width = 330;
            dgvData.Rows.Clear();
            _player.Clues.Reverse();
            foreach (Clue pClue in _player.Clues)
            {
                dgvData.Rows.Add(new[] {
                    pClue.Name, pClue.Description});
            }
            _player.Clues.Reverse();
        }

        private void SwapDialogueButton()
        {
            btnDialogue.Text = "Look";

            if(_currentNPC != null)
            {
                btnDialogue.Text = "Talk";
            }
        }

        private void UpdateDGV()
        {
            if (btnInventory.Enabled)
            {
                UpdateClueListInUI();
            }
            else
            {
                UpdateInventoryListInUI();
            }
        }

        private void btnInventory_Click(object sender = null, EventArgs e = null)
        {
            // Swap buttons
            btnInventory.Enabled = false;
            btnInventory.Visible = false;
            btnClues.Enabled = true;
            btnClues.Visible = true;

            // Enable labels
            lblInventory.Visible = true;
            lblClues.Visible = false;

            // Swap data
            UpdateInventoryListInUI();
        }

        private void btnClues_Click(object sender = null, EventArgs e = null)
        {
            // Swap buttons
            btnInventory.Enabled = true;
            btnInventory.Visible = true;
            btnClues.Enabled = false;
            btnClues.Visible = false;

            // Enable labels
            lblInventory.Visible = false;
            lblClues.Visible = true;

            // Swap data
            UpdateClueListInUI();
        }
    }
}
