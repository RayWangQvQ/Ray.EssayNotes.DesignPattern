using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class TriangleFactory : FactoryBase
    {
        public override ShapeBase CreateShape()
        {
            return new TriangleShape();
        }
    }
}