using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory3
{
    public class CircleShape : ShapeBase
    {
        public override string Name => "Circle";

        public override void Draw()
        {
            int size = this.Size;
            int midX = size;
            int midY = size;
            for (int i = 0; i <= 2 * size; i++)
            {
                for (int j = 0; j <= 2 * size; j++)
                {
                    if ((i - midX) * (i - midX) + (j - midY) * (j - midY) <= (size) * (size))
                        Console.Write(" *");
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}