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

        public Player(string name)
        {
            Name = name;
            Inventory = new List<Item>();
            Clues = new List<Clue>();
        }

        public bool checkForClues(Dialogue dialogue)
        {
            // Checks if this dialogue contains a clue
            Clue dialogueclue = World.ClueByDialogue(dialogue);
            if (dialogueclue != null)
            {
                // If a clue exists, add it to the clue list, then remove it
                Clues.Add(dialogueclue);
                dialogue.GiveClue = null;

                return true;
            }

            return false;
        }

        public bool checkForItems(Dialogue dialogue)
        {
            // Checks if this dialogue contains an item
            Item dialogueitem = World.ItemByDialogue(dialogue);
            if (dialogueitem != null)
            {
                // If an item exists, add it to the item list, then remove it
                Inventory.Add(dialogueitem);
                dialogue.GiveItem = null;

                return true;
            }

            return false;
        }

        public bool IsFlagCompleted(DialogueFlag flag)
        {
            // Checks if a dialogue flag meets all its conditions
            // Checks if the flag exists at all
            if (flag == null)
            {
                return false;
            }
            // Checks if we have the item and clue required for the flag, as well as whether the dialogue path is available
            if (Inventory.Contains(flag.ItemReq) && Clues.Contains(flag.ClueReq) && flag.NewDialoguePath != 0) {
                return true;
            }

            return false;
        }

    }
}
