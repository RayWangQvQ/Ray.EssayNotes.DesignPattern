using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AppService
    {
        public void Print(string shapeName)
        {
            FactoryBase factory;
            ShapeBase shape;
            ReporterBase reporter;

            factory = FactoryBase.GetFactory(shapeName);//这里其实还是耦合了。。。
            shape = factory.CreateShape();
            reporter = factory.CreateReport();

            shape.Prepare();
            shape.Draw();
            shape.End();

            reporter.Speak();
        }
    }
}