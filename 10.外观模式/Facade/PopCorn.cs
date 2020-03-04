using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Popcorn
    {
        public static Popcorn Instance = new Popcorn();
        private Popcorn()
        {
        }

        public void On()
        {
            Console.WriteLine("Popcorn on");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn off");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn is poping");
        }
    }
}