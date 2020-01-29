using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory2
{
    public class AppService
    {
        private readonly SimpleFactory _simpleFactory;
        public AppService()
        {
            _simpleFactory = new SimpleFactory();
        }

        public void Print(string shapeName)
        {
            ShapeBase shape = _simpleFactory.CreateShape(shapeName);
            if (shape == null) return;

            shape.Prepare();
            shape.Draw();
            shape.End();
        }
    }
}