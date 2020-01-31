using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class SquareFactory : FactoryBase
    {
        public override ShapeBase CreateShape()
        {
            return new SquareShape();
        }
    }
}