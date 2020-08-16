using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IAggregate aggregate = new ConcreteAggregate();
            aggregate.Add("1");
            aggregate.Add("2");
            aggregate.Add("3");

            //获取迭代器，用于访问器内部的集合
            IIterator iterator = aggregate.GetIterator();

            while(iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }

            Console.ReadLine();
        }
    }
}
