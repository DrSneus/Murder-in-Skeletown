using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsLocked { get; set; }
        public Clue ClueAvailableHere { get; set; }
        public NPC NPCHere { get; set; }
        public List<Location> AdjacentLocations { get; set; }
        public List<Dialogue> DialogueTree { get; set; }
        public DialogueFlag Flag { get; set; }

        public Location(int id, string name,
            bool isLocked = false,
            Clue clueAvailableHere = null,
            NPC npcHere = null)
        {
            ID = id;
            Name = name;
            IsLocked = isLocked;
            ClueAvailableHere = clueAvailableHere;
            NPCHere = npcHere;
            AdjacentLocations = new List<Location>();
            DialogueTree = new List<Dialogue>();
            Flag = null;
        }

        public void UnlockAdjacentLocations(DialogueFlag flag)
        {
            // Will unlock every adjacent location if the flag has been checked off
            // This limits the number of locked locations per area, but it's a worthwhile trade
            // for the simplicity of the solution.
            if(flag == null)
            {
                foreach (Location location in AdjacentLocations)
                {
                    location.IsLocked = false;
                }
            }
        }
    }
}
