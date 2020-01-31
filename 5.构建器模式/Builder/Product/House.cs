using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// 房子（组成比较复杂的类）
    /// </summary>
    public class House
    {
        /// <summary>
        /// 电视
        /// </summary>
        public Televison Televison { get; set; }

        /// <summary>
        /// 地板
        /// </summary>
        public Floor Floor { get; set; }

        /// <summary>
        /// 床
        /// </summary>
        public Bed Bed { get; set; }
    }
}