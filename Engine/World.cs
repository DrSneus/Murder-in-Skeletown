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
        public static readonly List<Clue> Clues = new List<Clue>();
        public static readonly List<NPC> NPCs = new List<NPC>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_NEWS = 1;
        public const int ITEM_ID_BEER = 2;

        public const int NPC_ID_BOUNCER = 1;

        public const int CLUE_ID_SOLVE_MURDER = 1;
        public const int CLUE_ID_CLOSED_BAR = 2;
        public const int CLUE_ID_MURDER_NOT_DEATH = 3;
        public const int CLUE_ID_SUS_GIFT = 4;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_CITY_SQUARE = 2;
        public const int LOCATION_ID_NIGHTCLUB = 3;
        public const int LOCATION_ID_INNIGHTCLUB= 4;
        public const int LOCATION_ID_MUSEUM = 5;

        static World()
        {
            PopulateItems();
            PopulateClues();
            PopulateNPCs();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Item(ITEM_ID_NEWS, "Today's Newspaper", "Features the obituary for Benny Bones"));
            Items.Add(new Item(ITEM_ID_BEER, "\'Skul\' Brand Beer", "Specialty drink from \"Bone Dry\""));
        }

        private static void PopulateClues()
        {
            // Creating clues
            Clue closedBar = new Clue(CLUE_ID_CLOSED_BAR, "The Closed Bar",
                "Why did the bouncer seem so on edge?",
                "Based on the bouncer's reaction, someone from the bar must have visited the museum last night");
            Clue murderNotDeath = new Clue(CLUE_ID_MURDER_NOT_DEATH, "Benny's Death",
                "Why do the police believe Benny's death was a murder?",
                null);
            Clue susGift = new Clue(CLUE_ID_SUS_GIFT, "CaBone's Gift",
                "What gift did CaBone receive yesterday?",
                null);

            // Adding clues to list
            Clues.Add(closedBar);
            Clues.Add(murderNotDeath);
            Clues.Add(susGift);
        }

        private static void PopulateNPCs()
        {
            // Creating NPCS
            NPC bouncer = new NPC(NPC_ID_BOUNCER, "Bouncer");

            // Creating Dialogue, and adding flags for additional dialogues

            // Bouncer NPC
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
               new double[] { 99 },
               ClueByID(CLUE_ID_CLOSED_BAR)));

            bouncer.Flag = new DialogueFlag(ClueByID(CLUE_ID_CLOSED_BAR), ItemByID(ITEM_ID_BEER), 0.3,
                "I found this beer at the crime scene, should I let the police know?",
                new Dialogue("Ok ok, you can see the boss. Just don't tell him I let you in.", 0.4,
                new string[] { "Thanks." },
                new double[] { 99 }));

            // Adding NPCs to List
            NPCs.Add(bouncer);
        }

        private static void PopulateLocations()
        {
            // Creating locations
            Location home = new Location(LOCATION_ID_HOME, "The Office");

            Location citySquare = new Location(LOCATION_ID_CITY_SQUARE, "City Square");

            Location nightclub = new Location(LOCATION_ID_NIGHTCLUB, "Bone Dry Bar - Exterior");
                nightclub.NPCHere = NPCByID(NPC_ID_BOUNCER);

            Location insideNightClub = new Location(LOCATION_ID_INNIGHTCLUB, "Bone Dry Bar - Interior", true);

            Location museum = new Location(LOCATION_ID_MUSEUM, "Museum - Exterior");

            // Linking locations
            home.AdjacentLocations.Add(citySquare);

            citySquare.AdjacentLocations.Add(nightclub);
            citySquare.AdjacentLocations.Add(home);
            citySquare.AdjacentLocations.Add(museum);

            nightclub.AdjacentLocations.Add(citySquare);
            nightclub.AdjacentLocations.Add(insideNightClub);

            insideNightClub.AdjacentLocations.Add(nightclub);

            museum.AdjacentLocations.Add(citySquare);


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

            museum.DialogueTree.Add(new Dialogue("The entrance is blocked with police tape, seems like you'll have to wait for the investigation to finish.", 0,
                new string[] { "Examine the museum's exterior", "Eavesdrop on the police" },
                new double[] { 0.1, 0.2 }));
            museum.DialogueTree.Add(new Dialogue("You notice an empty bottle of \"Skul\", a specialty drink at \"Bone Dry\".", 0.1,
                new string[] { "Eavesdrop on the police", "Enter the museum" },
                new double[] { 0.2, 0 },
                ItemByID(ITEM_ID_BEER)));
            museum.DialogueTree.Add(new Dialogue("\"Y'know, it's a real shame they were killed here. I hate associating this place with a murder.\"", 0.2,
                new string[] { "Examine the museum's exterior", "Enter the museum" },
                new double[] { 0.1, 0 },
                ClueByID(CLUE_ID_MURDER_NOT_DEATH)));

            insideNightClub.DialogueTree.Add(new Dialogue("Dozens of skeletons in suits are crowded around the bar. On stage, you see CaBone, the boss of the local mafia, preparing a speech", 0,
                new string[] { "Listen to the speech", "Observe the crowd's faces" },
                new double[] { 0.1, 0.2 }));
            insideNightClub.DialogueTree.Add(new Dialogue("\"My friends! I am delighted to have you join me here for my birthday this evening.\"", 0.1,
                new string[] { "Continue listening", "Observe the crowd's faces" },
                new double[] { 0.11, 0.2 }));
            insideNightClub.DialogueTree.Add(new Dialogue("\"Although I must confess, I already received my most anticipated gift yesterday at work...\"", 0.11,
                new string[] { "Continue listening", "Observe the crowd's faces" },
                new double[] { 0.111, 0.2 }));
            insideNightClub.DialogueTree.Add(new Dialogue("\"But this is a time of joy, so enough work talk! Let's party!\"", 0.111,
                new string[] { "Look around", "Observe the crowd's faces" },
                new double[] { 00, 0.2 }, 
                ClueByID(CLUE_ID_SUS_GIFT)));
            insideNightClub.DialogueTree.Add(new Dialogue("The crowd sounds joyful, but it's hard to read the facial expressions on skulls", 0.2,
                new string[] { "Look around", "Listen to the speaker" },
                new double[] { 0, 0.1 }));


            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(citySquare);
            Locations.Add(nightclub);
            Locations.Add(insideNightClub);
            Locations.Add(museum);
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

        public static Clue ClueByDialogue(Dialogue dialogue)
        {
            return dialogue.GiveClue;
        }

        public static Item ItemByDialogue(Dialogue dialogue)
        {
            return dialogue.GiveItem;
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