using System;

namespace SimpleFactory3
{
    /// <summary>
    /// 简单工厂模式（静态工厂模式），添加一个新的图形圆形
    /// </summary>
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
