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
        public Item CompletionItem { get; set; }

        public Clue(int id, string name, string description, Item completionitem, Item rewardItem = null)
        {
            ID = id;
            Name = name;
            Description = description;
            CompletionItem = completionitem;
            RewardItem = rewardItem;
        }
    }
}
