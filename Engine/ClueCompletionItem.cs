using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class ClueCompletionItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public ClueCompletionItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
