using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<NPC> NPCs = new List<NPC>();
        public static readonly List<Clue> Clues = new List<Clue>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_NEWS = 1;

        public const int NPC_ID_BOUNCER = 1;

        public const int CLUE_ID_CLEAR_SOLVE_MURDER = 1;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_CITY_SQUARE = 2;
        public const int LOCATION_ID_NIGHTCLUB = 3;

        static World()
        {
            PopulateItems();
            PopulateNPCs();
            PopulateClues();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Item(ITEM_ID_NEWS, "Today's Newspaper", "It features the obituary for Benny Bones"));
        }

        private static void PopulateNPCs()
        {
            // Creating NPCS
            NPC bouncer = new NPC(NPC_ID_BOUNCER, "Bouncer");

            // Creating NPC Dialogue Trees
            bouncer.DialogueTree.Add(new Dialogue("Sorry, no one in today unless you're invited.", 0,
                new string[] { "What's the occasion?", "Let me in. Now", "What do you know about Benny Bones' death?" },
                new double[] { 0.1, 0.2, 0.3 }));
            bouncer.DialogueTree.Add(new Dialogue("Boss's birthday, invite only.", 0.1,
               new string[] { "I see, thanks."},
               new double[] { 99 }));
            bouncer.DialogueTree.Add(new Dialogue("Ha, thanks for making me laugh", 0.2,
               new string[] { "Fine, I'm leaving" },
               new double[] { 99 }));
            bouncer.DialogueTree.Add(new Dialogue("Uhhh..umm..uh nothing. The boss definitely doesn't know anything either!", 0.3,
               new string[] { "Okay?" },
               new double[] { 99 }));

            // Adding NPCs to List
            NPCs.Add(bouncer);
        }

        private static void PopulateClues()
        {
            Clue solveMurder = new Clue(CLUE_ID_CLEAR_SOLVE_MURDER, "Why is the bar closed?",
                "The bouncer seemed on edge, maybe he's hiding the real reason the bar is closed",
                ItemByID(ITEM_ID_NEWS),
                NPCDialogueByID(NPCByID(NPC_ID_BOUNCER), 0.3));

            Clues.Add(solveMurder);
        }

        private static void PopulateLocations()
        {
            // Creating locations
            Location home = new Location(LOCATION_ID_HOME, "The Office");
                home.ClueAvailableHere = ClueByID(CLUE_ID_CLEAR_SOLVE_MURDER);

            Location citySquare = new Location(LOCATION_ID_CITY_SQUARE, "City Square");

            Location nightclub = new Location(LOCATION_ID_NIGHTCLUB, "Bone Dry Bar");
                nightclub.NPCHere = NPCByID(NPC_ID_BOUNCER);

            // Linking locations
            home.AdjacentLocations.Add(citySquare);

            citySquare.AdjacentLocations.Add(nightclub);
            citySquare.AdjacentLocations.Add(home);

            nightclub.AdjacentLocations.Add(citySquare);

            // Adding location dialogue
            home.DialogueTree.Add(new Dialogue("Your place of work, located just outside Skeletown", 0,
                new string[] { "Review the clues", "Water the office plant" },
                new double[] { 0.1, 0.2 }));
            home.DialogueTree.Add(new Dialogue("Benny Bones was found with his skull cracked outside the museum \"The Bones of History\"", 0.1,
                new string[] { "Water the office plant", "Look around the office" },
                new double[] { 0.2, 0 }));
            home.DialogueTree.Add(new Dialogue("He's looking alive and healthy, unlike Benny.", 0.2,
                new string[] { "Review the clues", "Look around the office" },
                new double[] { 0.1, 0 }));

            citySquare.DialogueTree.Add(new Dialogue("Skeletons are walking around the city's downtown. Nearby is the town museum, and the bar \"Bone Dry\"", 0,
                new string[] { "Look at the townspeople", "Take a smoke break" },
                new double[] { 0.1, 0.2 }));
            citySquare.DialogueTree.Add(new Dialogue("The skeletons around town seem to disregard your presence.", 0.1,
                new string[] { "Take a smoke break", "Look around town" },
                new double[] { 0.2, 0 }));
            citySquare.DialogueTree.Add(new Dialogue("You look for a cigarette, before you remember that you don't smoke, as you lack lungs.", 0.2,
                new string[] { "Look at the townspeople", "Look around town" },
                new double[] { 0.1, 0 }));

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(citySquare);
            Locations.Add(nightclub);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static NPC NPCByID(int id)
        {
            foreach (NPC NPC in NPCs)
            {
                if (NPC.ID == id)
                {
                    return NPC;
                }
            }

            return null;
        }

        public static Clue ClueByID(int id)
        {
            foreach (Clue clue in Clues)
            {
                if (clue.ID == id)
                {
                    return clue;
                }
            }

            return null;
        }

        public static Clue ClueByDialogue(Dialogue dialogue)
        {
            foreach (Clue clue in Clues)
            {
                if (clue.ClueFlag == dialogue)
                {
                    return clue;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }

        public static Dialogue NPCDialogueByID(NPC npc, double dialogueID)
        {
            foreach (Dialogue dialogue in npc.DialogueTree)
            {
                if (dialogue.ID == dialogueID)
                {
                    return dialogue;
                }
            }

            return null;
        }

        public static Dialogue LocationDialogueByID(Location location, double dialogueID)
        {
            foreach (Dialogue dialogue in location.DialogueTree)
            {
                if (dialogue.ID == dialogueID)
                {
                    return dialogue;
                }
            }

            return null;
        }
    }
}