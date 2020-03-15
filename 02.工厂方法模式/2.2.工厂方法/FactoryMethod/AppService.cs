using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class AppService
    {
        public void Print(string shapeName)
        {
            FactoryBase factory;
            ShapeBase shape;

            factory = FactoryBase.GetFactory(shapeName);//这里其实还是耦合了。。。
            shape = factory.CreateShape();

            shape.Prepare();
            shape.Draw();
            shape.End();
        }
    }
}