using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player
    {
        public string Name { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<Clue> Clues { get; set; }
        public Location CurrentLocation { get; set; }

        public List<Location> VisitedLocations = new List<Location>();

        public Player(string name)
        {
            Name = name;
            Inventory = new List<InventoryItem>();
            Clues = new List<Clue>();
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
            // See if the player has all the items needed
            // to complete the clue here
            foreach (ClueCompletionItem qci in clue.ClueCompletionItems)
            {
                bool foundItemInPlayersInventory = false;
                // Search for items in the player's inventory
                foreach (InventoryItem ii in Inventory)
                {
                    // The player has the item in their inventory
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        foundItemInPlayersInventory = true;
                        // The player has enough
                        if (ii.Quantity >= qci.Quantity)
                        {
                            break;
                        }

                        // The player does not have enough
                        else
                        {
                            return false;
                        }
                    }
                }

                // Player is missing a necessary itmm
                if (!foundItemInPlayersInventory)
                {
                    return false;
                }
            }
            // Player has all required items
            return true;
        }

        public void RemoveClueCompletionItems(Clue clue)
        {
            foreach (ClueCompletionItem qci in clue.ClueCompletionItems)
            {
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        // Subtract the quantity from the player's
                        // inventory that was needed to complete the clue
                        ii.Quantity -= qci.Quantity;
                        break;
                    }
                }
            }
        }

        public void AddItemToInventory(Item itemToAdd)
        {
            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == itemToAdd.ID)
                {
                    // They have the item in their inventory, so increase
                    // the quantity by one
                    ii.Quantity++;
                    return;
                }
            }
            // They didn't have the item, so add it to their inventory,
            // with a quantity of 1
            Inventory.Add(new InventoryItem(itemToAdd, 1));
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
