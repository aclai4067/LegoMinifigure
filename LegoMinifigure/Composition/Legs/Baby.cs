﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Legs
{
    class Baby
    {
        public bool CanWalk { get; set; }
        public int NumberOfRolls { get; set; }
        public bool IsClumsy => true;
        public bool HasPants { get; set; }

        public void Walk(int steps)
        {
            if (CanWalk)
            {
                Console.WriteLine($"Baby legs walk {steps} steps and then topple over.");
            }
            else
            {
                Console.WriteLine($"Baby legs crawl {steps} baby feet");
            }
        }

        public void Kick()
        {
            Console.WriteLine($"Baby legs kick with the power of {NumberOfRolls} thigh rolls!");
        }
    }
}
