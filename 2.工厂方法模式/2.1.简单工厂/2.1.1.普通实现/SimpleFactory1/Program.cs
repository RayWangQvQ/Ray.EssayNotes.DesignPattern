using System;

namespace SimpleFactory1
{
    /// <summary>
    /// 不使用简单工厂，实现一个在控制台画图的程序
    /// </summary>
    class Program
    {
        static string CONSTSTR = "Square、Triangle";

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
