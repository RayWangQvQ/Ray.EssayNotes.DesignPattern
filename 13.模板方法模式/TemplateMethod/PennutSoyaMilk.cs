using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class PennutSoyaMilk : SoyaMilk
    {
        public override void Add()
        {
            Console.WriteLine("第二步：添加花生");
        }
    }
}