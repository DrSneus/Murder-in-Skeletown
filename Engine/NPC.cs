using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class NPC
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Dialogue> DialogueTree { get; set; }
        public DialogueFlag Flag { get; set; }

        public NPC(int id, string name)
        {
            ID = id;
            Name = name;
            DialogueTree = new List<Dialogue>();
            Flag = null;
        }
    }
}
