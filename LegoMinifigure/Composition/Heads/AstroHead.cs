using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Heads
{

    enum LegoColor
    {
        Yellow,
        Red,
        Green,
        White,
        Grey,
        Blue,
        Black,
        Orange,
        Brown
    }
       
    class AstroHead
    {
        public bool Helmeted { get; set; }
        public string FacialExpression { get; set; }
        public LegoColor Color { get; set; }
        public LegoColor EyeColor { get; set; }

        public void Talk()
        {
            Console.WriteLine($"The astronaut says 'Tell my wife I love her very much.' while {FacialExpression} emphatically.");
        }

        public void EatPie(string typeOfPie)
        {
            if (typeOfPie.ToLower() == "apple")
            {
                Console.WriteLine("mmm, pie");
            }
            else
            {
                Console.WriteLine("This is not pie");
            }
        }
    }
}
