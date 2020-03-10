using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Torsos
{
    enum HandType
    {
        Human,
        Robot,
        Baby,
        Tentacles,
        CanadaArm,
        XBuster
    }

    class AstroTorso
    {
        public int NumberOfArms { get; set; }
        public bool ChiseledAbs { get; set; }
        public bool HasShirt { get; set; }
        public HandType Hands { get; set; }

        public void Flex()
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
    }
}
