using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory3
{
    public class SimpleFactory
    {
        public static ShapeBase CreateShape(string shapeName)
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
                case "Circle":
                    shape = new CircleShape();
                    break;
                default:
                    Console.WriteLine("暂无该图形，可重新输入");
                    shape = null;
                    break;
            }
            return shape;
        }
    }
}