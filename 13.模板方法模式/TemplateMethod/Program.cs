using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("开始制作红豆豆浆");
            SoyaMilk redBeanMilk = new RedBeanSoyaMilk();
            redBeanMilk.Make();

            Console.WriteLine("开始制作花生豆浆");
            SoyaMilk pennutMilk = new PennutSoyaMilk();
            pennutMilk.Make();

            Console.ReadLine();
        }
    }
}
