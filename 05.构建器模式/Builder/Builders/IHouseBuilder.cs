using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IHouseBuilder
    {
        House House { get; set; }

        /// <summary>
        /// 构建地板
        /// </summary>
        /// <param name="floorName"></param>
        /// <returns></returns>
        IHouseBuilder BuildFloor(string floorName);

        /// <summary>
        /// 构建电视
        /// </summary>
        /// <param name="tvName"></param>
        /// <returns></returns>
        IHouseBuilder BuildTV(string tvName);

        /// <summary>
        /// 构建床
        /// </summary>
        /// <param name="bedName"></param>
        /// <returns></returns>
        IHouseBuilder BuilBed(string bedName);

        House Build();
    }
}