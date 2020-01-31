using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SquareShape : ShapeBase
    {
        public override string Name => "Square";

        public override void Draw()
        {
            int size = this.Size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}