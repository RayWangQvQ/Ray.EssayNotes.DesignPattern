using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class DVDPlayer
    {
        public static DVDPlayer Instance = new DVDPlayer();
        private DVDPlayer()
        {
        }

        public void On()
        {
            Console.WriteLine("DVD on");
        }

        public void Off()
        {
            Console.WriteLine("DVD off");
        }

        public void Play()
        {
            Console.WriteLine("DVD play");
        }

        public void Pause()
        {
            Console.WriteLine("DVD stop");
        }
    }
}