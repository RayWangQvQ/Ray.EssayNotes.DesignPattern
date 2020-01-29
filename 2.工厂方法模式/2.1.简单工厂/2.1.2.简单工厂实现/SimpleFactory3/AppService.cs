using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory3
{
    public class AppService
    {
        public void Print(string shapeName)
        {
            ShapeBase shape = SimpleFactory.CreateShape(shapeName);
            if (shape == null) return;

            shape.Prepare();
            shape.Draw();
            shape.End();
        }
    }
}