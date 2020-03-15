using System;

namespace Singleton1
{
    /// <summary>
    /// 饿汉式（静态字段）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Singleton instance = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();

            Console.WriteLine(instance == instance2); 
            Console.WriteLine($"instance.hashCode={instance.GetHashCode()}");
            Console.WriteLine($"instance2.hashCode={instance2.GetHashCode()}");
        }
    }
}
