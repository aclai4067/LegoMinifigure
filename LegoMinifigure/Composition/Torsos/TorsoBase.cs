using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Torsos
{
    abstract class TorsoBase // abstract keeps class from being instantiated, can only use as part of other classes, not on its own
    {
        public abstract bool ChiseledAbs { get; set; }
        public bool HasShirt { get; set; }
        public HandType Hands { get; set; }

        public abstract void Flex(); // method is required for all torsos, but does not define scope of the method

        public virtual void Breathe() // sets default scope for method but can be changed by any class inheriting the method
        { 
            Console.WriteLine("Inhale. Exhale");
        }
    }
}
