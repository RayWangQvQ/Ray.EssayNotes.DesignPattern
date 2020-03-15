using System;

namespace AbstractFactory
{
    class Program
    {
        static string CONSTSTR = "Square、Triangle、Circle";

        static void Main(string[] args)
        {
            AppService service = new AppService();
            while (true)
            {
                Console.WriteLine($"请输入要绘制的图形名称：{CONSTSTR}");
                string name = Console.ReadLine();

                service.Print(name);
            }
        }
    }
}
