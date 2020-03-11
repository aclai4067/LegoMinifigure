using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Torsos
{
    class DadBodTorso : TorsoBase
    {
        public bool IsHairy { get; set; }
        public override bool ChiseledAbs 
        { 
            get { return false; }
            set { }
        }



        public void ChangeThermostat (string Weather)
        {
            if (Weather.ToLower() == "cold")
            {
                Console.WriteLine("Dad bod turns down the thermostat");
            }
            else
            {
                Console.WriteLine("Dad bod turns up the thermostat");
            }
        }

        public override void Flex()
        {
            Console.WriteLine($@"The dad flexes his {(IsHairy ? "hairy" : "smooth")} bod 
                              while using his {Hands} hands to point at his flabby arms.");
        }
    }
}
