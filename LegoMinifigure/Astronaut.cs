using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure
{ 
    enum Location // place in it's own .cs file if this is being used by multiple classes. implicitly internal
        {
            Earth,
            Space,
            SpaceStation
        }

    class Astronaut
    {
        public Location Location { get; set; } //using enum for type, will default to index 0
        public bool SuitedUp => Name == "Major Tom"; //expression bodied property, tells it to always do this thing in this condition(read only property)
        public string Name { get; } //removing set makes value read only, can only bet set once in the constructor
        public string Job { get; private set; } // private set must be set by the constructor or a method in this class
        public int O2Level { private get; set; } //can't read the property, but can set it (useful for sensitive info)

        public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public void Promote()
        {
            Job = $"Commander of {Job} staff";
        }

        public void DoYourJob()
        {
            switch (Job)
            {
                default:
                    Console.WriteLine($"{Name} is doing all their {Job} duties...");
                    break;
            }
        }
    }
}
