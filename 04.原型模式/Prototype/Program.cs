using System;
using System.Text.Json;//添加引用

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("普通写法：");
            Func1();
            Console.WriteLine("原型模式（浅拷贝）：");
            Func2();
            Console.WriteLine("原型模式（深拷贝）：");
            Func3();

            Console.ReadLine();
        }

        /// <summary>
        /// 普通方式clone
        /// </summary>
        static void Func1()
        {
            Sheep sheep = new Sheep
            {
                Name = "DuoLi",
                Age = 10,
                Color = new SheepColor { Code = "001", Name = "White" }
            };

            Sheep sheep1 = new Sheep { Name = sheep.Name, Age = sheep.Age, Color = sheep.Color };
            Sheep sheep2 = new Sheep { Name = sheep.Name, Color = sheep.Color, Age = sheep.Age };

            MyPrint(sheep);
            MyPrint(sheep1);
            MyPrint(sheep2);
        }

        /// <summary>
        /// 原型模式-浅拷贝
        /// </summary>
        static void Func2()
        {
            Sheep sheep = new Sheep
            {
                Name = "DuoLi",
                Age = 10,
                Color = new SheepColor { Code = "001", Name = "White" }
            };

            Sheep sheep1 = (Sheep)sheep.Clone();
            Sheep sheep2 = (Sheep)sheep.Clone();

            MyPrint(sheep);
            MyPrint(sheep1);
            MyPrint(sheep2);
        }

        /// <summary>
        /// 原型模式-深拷贝
        /// </summary>
        static void Func3()
        {
            Sheep sheep = new Sheep
            {
                Name = "DuoLi",
                Age = 10,
                Color = new SheepColor { Code = "001", Name = "White" }
            };

            Sheep sheep1 = (Sheep)sheep.DeepClone();
            Sheep sheep2 = (Sheep)sheep.DeepClone();

            MyPrint(sheep);
            MyPrint(sheep1);
            MyPrint(sheep2);
        }

        private static void MyPrint(Sheep sheep)
        {
            Console.Write(JsonSerializer.Serialize(sheep));
            Console.Write($"，SheepHashCode：{sheep.GetHashCode()}");
            Console.Write($"，ColorHashCode：{sheep.Color.GetHashCode()}");
            Console.WriteLine();
        }
    }
}
