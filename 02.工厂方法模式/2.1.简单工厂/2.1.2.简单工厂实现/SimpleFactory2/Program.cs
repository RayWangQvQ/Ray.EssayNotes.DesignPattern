using System;

namespace SimpleFactory2
{
    /// <summary>
    /// 使用简单工厂模式，进行重构优化
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
