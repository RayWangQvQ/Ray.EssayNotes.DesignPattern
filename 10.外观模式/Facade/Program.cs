using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade();

            homeTheaterFacade.Ready();
            homeTheaterFacade.Pause();
            homeTheaterFacade.End();

            Console.ReadLine();
        }
    }
}
