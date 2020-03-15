using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class TriangleReporter : ReporterBase
    {
        public override void Speak()
        {
            Console.WriteLine("这是三角形");
        }
    }
}