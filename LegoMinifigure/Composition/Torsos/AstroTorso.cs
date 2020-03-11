using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Torsos
{
    class AstroTorso : TorsoBase
    {
        public int NumberOfArms { get; set; }
        public override bool ChiseledAbs { get; set; }


        public override void Flex() // use override to define abstract methods
        {
            if (ChiseledAbs && !HasShirt)
            {
                Console.WriteLine("Check out my sick abs!");
            }
            else if (Hands == HandType.XBuster)
            {
                Console.WriteLine("Welcome to the gun show! Pew, pew!");
            }
            else
            {
                Console.WriteLine("Weird flex, but okay");
            }
        }

        public override void Breathe()
        {
            Console.WriteLine("Exhale, Inhale");
        }
    }
}
