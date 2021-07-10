using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsLocked { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public NPC NPCHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location(int id, string name, string description,
            bool isLocked = false,
            Quest questAvailableHere = null,
            NPC npcHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            IsLocked = isLocked;
            QuestAvailableHere = questAvailableHere;
            NPCHere = npcHere;
        }
    }
}
