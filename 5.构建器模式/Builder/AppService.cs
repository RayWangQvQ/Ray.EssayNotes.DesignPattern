using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class AppService
    {
        private IHouseBuilder IHouseBuilder;

        public AppService()
        {
            IHouseBuilder = new HouseBuilderA();
        }


        public House GetHouse()
        {
            House h = IHouseBuilder.BuilBed("榻榻米")
                .BuildFloor("实木地板")
                .BuildTV("索尼电视")
                .Build();
            return h;
        }
    }
}