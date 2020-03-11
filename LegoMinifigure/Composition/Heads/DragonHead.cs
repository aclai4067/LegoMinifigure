using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Heads
{
    enum BreathType
    {
        Stanky,
        Fire,
        Poison,
        Ice
    }
    class DragonHead
    {
        public int NumberOfTeeth { get; set; }
        public bool hasSpikes { get; set; }
        public LegoColor ScaleColor { get; set; }
        public BreathType Breath { get; set; }

        public void Talk()
        {
            Console.WriteLine("You are crunchy and good with ketchup.");
        }

        public void Breathe()
        {
            Console.WriteLine($"Dragon attacks with {Breath} breath.");
        }
    }
}
