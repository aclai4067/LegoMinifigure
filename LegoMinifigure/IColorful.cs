using LegoMinifigure.Composition.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure
{
    interface IColorful
    {
        LegoColor Color { get; } //cannot add access modifiers, will always be public
    }

    interface ILegoPiece: IMoveable, IColorful
    {

    }
}

// idiomatic nameing for interfaces: I + adjective

// better to have multiple small interfaces than one large one because you limit yourself by 
// putting too many stipulations in one.  For example, if move and color are in the same interface
// but a piece does not move, this becomes problematic.  You can create an interface that implements 
// multiple other interfaces that are frequently paired (see ILegoPiece)

// what is the difference between abstract classes and interfaces?
// Interface is like a "contract", everything must be used
// you can only inherit one abstract class but multiple interfaces
// interfaces cannot define behavior like an abstract class
