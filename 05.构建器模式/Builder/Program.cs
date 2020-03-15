using System;
using System.Text.Json;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AppService service = new AppService();
            House product = service.GetHouse();

            Console.WriteLine(JsonSerializer.Serialize(product));

            Console.ReadLine();
        }
    }
}
