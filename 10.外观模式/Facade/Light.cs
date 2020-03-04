using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Light
    {
        public static Light Instance = new Light();
        private Light()
        {
        }

        public void Bright()
        {
            Console.WriteLine("Light bright");
        }

        public void Dim()
        {
            Console.WriteLine("Light dim");
        }
    }
}