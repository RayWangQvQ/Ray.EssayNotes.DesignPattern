using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class HouseBuilderB : IHouseBuilder
    {
        public House House { get; set; }

        public IHouseBuilder BuilBed(string bedName)
        {
            throw new NotImplementedException();
        }

        public House Build()
        {
            throw new NotImplementedException();
        }

        public IHouseBuilder BuildFloor(string floorName)
        {
            throw new NotImplementedException();
        }

        public IHouseBuilder BuildTV(string tvName)
        {
            throw new NotImplementedException();
        }
    }
}