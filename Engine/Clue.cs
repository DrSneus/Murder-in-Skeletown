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
        public Item RewardItem { get; set; }
        public List<ClueCompletionItem> ClueCompletionItems { get; set; }
        public Dialogue ClueFlag { get; set; }

        public Clue(int id, string name, string description, Dialogue dialogue, Item rewardItem = null)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardItem = rewardItem;
            ClueCompletionItems = new List<ClueCompletionItem>();
            ClueFlag = dialogue;
        }
    }
}
