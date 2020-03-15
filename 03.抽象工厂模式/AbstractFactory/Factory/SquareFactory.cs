using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SquareFactory : FactoryBase
    {
        public override ReporterBase CreateReport()
        {
            return new SquareReportor();
        }

        public override ShapeBase CreateShape()
        {
            return new SquareShape();
        }
    }
}