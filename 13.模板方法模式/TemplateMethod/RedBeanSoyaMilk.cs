using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class RedBeanSoyaMilk : SoyaMilk
    {
        public override void Add()
        {
            Console.WriteLine("第二步：添加红豆");
        }
    }
}