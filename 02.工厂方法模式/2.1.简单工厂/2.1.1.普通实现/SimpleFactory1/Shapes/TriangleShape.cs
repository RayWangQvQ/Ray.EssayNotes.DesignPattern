using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory1
{
    public class TriangleShape : ShapeBase
    {
        public override string Name => "Triangle";

        public override void Draw()
        {
            int size = this.Size;
            for (int i = 0; i < size; i++)
            {
                for (int k = size - 1 - i; k > 0; k--)
                    Console.Write(" ");
                for (int j = 0; j < i + 1; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
    }
}