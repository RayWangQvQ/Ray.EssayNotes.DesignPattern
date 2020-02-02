using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //单品黑咖啡
            Coffee coffee = new LongBlack();
            MyPrint(coffee);

            //黑咖啡的基础上+牛奶
            coffee = new Milk(coffee);//生成装饰对象（牛奶）的同时将之前被装饰者（黑咖啡）注进去，达到累加效果
            MyPrint(coffee);

            //依此类推
            //可以继续添加装饰者
            coffee = new Chocolate(coffee);
            MyPrint(coffee);

            Console.ReadLine();
        }

        private static void MyPrint(Coffee coffee)
        {
            Console.WriteLine($"描述={coffee.Desc}，费用={coffee.Price}");

        }
    }
}
