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

        public void checkForClues(Dialogue dialogue)
        {
            Clue dialogueclue = World.ClueByDialogue(dialogue);
            if (dialogueclue != null)
            {
                Clues.Add(dialogueclue);
                dialogue.GiveClue = null;
            }
        }

        public void checkForItems(Dialogue dialogue)
        {
            Item dialogueitem = World.ItemByDialogue(dialogue);
            if (dialogueitem != null)
            {
                Inventory.Add(dialogueitem);
                dialogue.GiveItem = null;
            }
        }

        public bool HasThisClue(Clue clue)
        {
            foreach (Clue playerClue in Clues)
            {
                if (playerClue.ID == clue.ID)
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasAllClueCompletionItems(Clue clue)
        {
            // See if the player has the item to solve the clue
            bool playerHasItem = false;

            // Search for items in the player's inventory
            foreach (Item i in Inventory)
            {
                // The player has the item in their inventory
                if (i.ID == clue.CompletionItem.ID)
                {
                    playerHasItem = true;
                    break;
                }
            }

            return playerHasItem;
        }

        public void RemoveClueCompletionItems(Clue clue)
        {
            foreach (Item i in Inventory)
            {
                if (i.ID == clue.CompletionItem.ID)
                {
                    Inventory.Remove(i);
                    break;
                }
            }
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
