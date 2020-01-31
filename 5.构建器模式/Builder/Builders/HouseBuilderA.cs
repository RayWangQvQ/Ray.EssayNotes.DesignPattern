using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class HouseBuilderA : IHouseBuilder
    {
        public House House { get; set; }
        public HouseBuilderA()
        {
            House = new House();
        }

        public IHouseBuilder BuildFloor(string floorName)
        {
            var floor = new Floor { Name = floorName };
            this.House.Floor = floor;
            return this;
        }

        public IHouseBuilder BuildTV(string tvName)
        {
            var tv = new Televison { Name = tvName };
            this.House.Televison = tv;
            return this;
        }

        public IHouseBuilder BuilBed(string bedName)
        {
            var bed = new Bed { Name = bedName };
            this.House.Bed = bed;
            return this;
        }

        public House Build()
        {
            return this.House;
        }
    }
}