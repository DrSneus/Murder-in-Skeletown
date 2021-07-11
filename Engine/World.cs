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
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_GUN = 1;

        public const int NPC_ID_BOUNCER = 1;

        public const int QUEST_ID_CLEAR_SOLVE_MURDER = 1;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_CITY_SQUARE = 2;
        public const int LOCATION_ID_NIGHTCLUB = 3;

        static World()
        {
            PopulateItems();
            PopulateNPCs();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Item(ITEM_ID_GUN, "An old gun"));
        }

        private static void PopulateNPCs()
        {
            // Bouncer NPC
            List<Dialogue> BOUNCER_TREE = new List<Dialogue>();
            BOUNCER_TREE.Add(new Dialogue("Sorry, no one in today unless you're invited.", 0,
                new string[] { "What's the occasion?", "Let me in. Now", "What do you know about the murder?" },
                new double[] { 0.1, 0.2, 0.3 }));
            BOUNCER_TREE.Add(new Dialogue("Boss's birthday, invite only.", 0.1,
               new string[] { "I see, thanks."},
               new double[] { 99 }));
            BOUNCER_TREE.Add(new Dialogue("Ha, thanks for making me laugh", 0.2,
               new string[] { "Fine, I'm leaving" },
               new double[] { 99 }));
            BOUNCER_TREE.Add(new Dialogue("Uhhh..umm..uh nothing. The boss definitely doesn't know anything either!", 0.3,
               new string[] { "Okay?" },
               new double[] { 99 }));

            NPCs.Add(new NPC(NPC_ID_BOUNCER, "Bouncer", BOUNCER_TREE));
        }

        private static void PopulateQuests()
        {
            Quest solveMurder = new Quest(QUEST_ID_CLEAR_SOLVE_MURDER, "Solve the Murder",
                "Find out who's behind the murder in Skeletown");

            solveMurder.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_GUN), 1));
            Quests.Add(solveMurder);
        }

        private static void PopulateLocations()
        {
            // Creating locations
            Location home = new Location(LOCATION_ID_HOME, "The Office",
                "Your place of work, located just outside Skeletown");

            home.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_SOLVE_MURDER);

            Location citySquare = new Location(LOCATION_ID_CITY_SQUARE,
                "City Square", "Skeletons are walking around the city.");

            Location nightclub = new Location(LOCATION_ID_NIGHTCLUB,
                "Bone Dry Bar", "A nightclub popular with young skeletons");
                nightclub.NPCHere = NPCByID(NPC_ID_BOUNCER);

            // Linking locations
            home.AdjacentLocations.Add(citySquare);

            citySquare.AdjacentLocations.Add(nightclub);
            citySquare.AdjacentLocations.Add(home);

            nightclub.AdjacentLocations.Add(citySquare);

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

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
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

        public static Dialogue DialogueByID(NPC npc, double dialogueID)
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
    }
}