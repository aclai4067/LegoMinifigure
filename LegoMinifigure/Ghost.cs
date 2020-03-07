using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure
{
    class Ghost
    {
        public bool IsFriendly { get; set; }
        public bool IsVisible { get; set; }
        public DateTime DeathDay { get; }
        public string Name { get; set; }
        public string HauntingLocation { get; private set; }

        public Ghost(string name, DateTime deathDay)
        {
            Name = name;
            DeathDay = deathDay;
        }

        public void Haunt(string hauntingLocation)
        {
            HauntingLocation = hauntingLocation;
            Console.WriteLine($"{Name} moved to {HauntingLocation}");
        }

        public void Spook()
        {
            if (string.IsNullOrEmpty(HauntingLocation)) return;
            Console.WriteLine($"{Name} does a spook at {HauntingLocation}");
        }
    }
}
