using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class LivingCreature
    {
        public int MaximumHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }

        public LivingCreature(int currentHitPoints,
            int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }
    }
}
