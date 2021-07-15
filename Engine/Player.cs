using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player
    {
        public string Name { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Clue> Clues { get; set; }
        public Location CurrentLocation { get; set; }

        public List<Location> VisitedLocations = new List<Location>();

        public Player(string name)
        {
            Name = name;
            Inventory = new List<Item>();
            Clues = new List<Clue>();
        }

        public bool checkForClues(Dialogue dialogue)
        {
            Clue dialogueclue = World.ClueByDialogue(dialogue);
            if (dialogueclue != null)
            {
                Clues.Add(dialogueclue);
                dialogue.GiveClue = null;

                return true;
            }

            return false;
        }

        public bool checkForItems(Dialogue dialogue)
        {
            Item dialogueitem = World.ItemByDialogue(dialogue);
            if (dialogueitem != null)
            {
                Inventory.Add(dialogueitem);
                dialogue.GiveItem = null;

                return true;
            }

            return false;
        }

        public bool IsFlagCompleted(DialogueFlag flag)
        {
            if (flag == null)
            {
                return false;
            }

            if (Inventory.Contains(flag.ItemReq) && Clues.Contains(flag.ClueReq) && flag.NewDialoguePath != 0) {
                return true;
            }

            return false;
        }

        public void AddItemToInventory(Item itemToAdd)
        {
            foreach (Item i in Inventory)
            {
                // If the player has the item, skip adding it
                if (i.ID == itemToAdd.ID)
                {
                    return;
                }
            }
            // They didn't have the item, so add it to their inventory
            Inventory.Add(itemToAdd);
        }

        public bool IsNewLocation(Location location)
        {
            // Checks if the location has been visited yet
            if (VisitedLocations.Contains(location) != true)
            {
                VisitedLocations.Add(location);
                return true;
            }

            return false;
        }

    }
}
