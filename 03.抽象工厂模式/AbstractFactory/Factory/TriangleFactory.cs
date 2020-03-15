using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class TriangleFactory : FactoryBase
    {
        public override ReporterBase CreateReport()
        {
            return new TriangleReporter();
        }

        public override ShapeBase CreateShape()
        {
            return new TriangleShape();
        }
    }
}