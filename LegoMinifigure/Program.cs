using LegoMinifigure.Composition.Heads;
using LegoMinifigure.Composition.Legs;
using LegoMinifigure.Composition.Torsos;
using System;


namespace LegoMinifigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new AstroHead()
            {
                FacialExpression = "Smiling",
                Color = LegoColor.Yellow,
                EyeColor = LegoColor.Green,
                Helmeted = true
            };

            var torso = new AstroTorso()
            {
                Hands = HandType.Baby,
                ChiseledAbs = true,
                HasShirt = true,
                NumberOfArms = 3
            };

            var legs = new AstroLegs()
            {
                HasPants = true,
                Shoes = ShoeType.MoonBoots
            };

            var astronaut = new Astronaut("Major Tom", "Janitor", head, torso, legs);
            astronaut.Promote();
            astronaut.DoYourJob();

            var casper = new Ghost("Casper", DateTime.Today)
            {
                IsFriendly = true,
                IsVisible = true,
            };
            var stretch = new Ghost("Stretch", new DateTime(1895, 12, 1))
            {
                IsFriendly = false
            };
            casper.Spook();
            casper.Haunt("Whipstaff Manor");
            casper.Spook();


            Console.ReadKey();
        }
    }
}
