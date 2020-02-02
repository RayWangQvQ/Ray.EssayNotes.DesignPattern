using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Milk : Decorator
    {
        /// <summary>
        /// 牛奶
        /// </summary>
        /// <param name="coffee"></param>
        public Milk(Coffee coffee) : base(coffee)
        {
            this.Desc = "牛奶";
            this.Price = 2;
        }
    }
}