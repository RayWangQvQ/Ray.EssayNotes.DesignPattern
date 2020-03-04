using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class HomeTheaterFacade
    {
        private Popcorn _popcorn;
        private DVDPlayer _dvdPlayer;
        private Light _light;
        public HomeTheaterFacade()
        {
            _popcorn = Popcorn.Instance;
            _dvdPlayer = DVDPlayer.Instance;
            _light = Light.Instance;
        }

        public void Ready()
        {
            _popcorn.On();
            _popcorn.Pop();
            _light.Dim();
            _dvdPlayer.On();
        }

        public void Pause()
        {
            _dvdPlayer.Pause();
        }

        public void End()
        {
            _popcorn.Off();
            _light.Bright();
            _dvdPlayer.Off();
        }
    }
}