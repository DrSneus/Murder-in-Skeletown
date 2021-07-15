using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Clue
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CompletedDescription { get; set; }

        public Clue(int id, string name, string description, string completed)
        {
            ID = id;
            Name = name;
            Description = description;
            CompletedDescription = completed;
        }
    }
}
