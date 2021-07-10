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
            NPCs.Add(new NPC(NPC_ID_BOUNCER, "Bouncer"));
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
                "Bone Dry", "A nightclub popular with young skeletons");

            // Linking locations
            home.LocationToNorth = citySquare;

            citySquare.LocationToWest = nightclub;
            citySquare.LocationToSouth = home;

            nightclub.LocationToEast = citySquare;

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
    }
}