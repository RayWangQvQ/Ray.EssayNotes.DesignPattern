using System;

namespace Singleton2
{
    /// <summary>
    /// 线程不安全懒汉式（错误写法）
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
