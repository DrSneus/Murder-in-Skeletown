using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class PlayerClue
    {
        public Clue Details { get; set; }
        public bool IsCompleted { get; set; }

        public PlayerClue(Clue details)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
