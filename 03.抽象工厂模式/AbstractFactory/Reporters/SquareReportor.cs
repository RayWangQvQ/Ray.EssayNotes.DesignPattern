using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SquareReportor : ReporterBase
    {
        public override void Speak()
        {
            Console.WriteLine("这时圆形");
        }
    }
}