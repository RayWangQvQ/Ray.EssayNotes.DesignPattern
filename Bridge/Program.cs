using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Phone phone = new FoldedPhone(new XiaoMi());
            phone.Open();
            phone.Call();
            phone.Close();

            Console.ReadLine();
        }
    }
}
