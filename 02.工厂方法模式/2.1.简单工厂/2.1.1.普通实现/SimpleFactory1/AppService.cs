using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory1
{
    public class AppService
    {
        public void Print(string shapeName)
        {
            ShapeBase shape;
            switch (shapeName)
            {
                case "Square":
                    shape = new SquareShape();
                    break;
                case "Triangle":
                    shape = new TriangleShape();
                    break;
                default:
                    Console.WriteLine("暂无该图形，可重新输入");
                    return;
            }

            shape.Prepare();
            shape.Draw();
            shape.End();
        }
    }
}