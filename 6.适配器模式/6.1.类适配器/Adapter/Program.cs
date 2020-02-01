using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ITarget classAdapter = new ClassAdapter();
            classAdapter.Charging();

            Console.ReadLine();
        }
    }
}
