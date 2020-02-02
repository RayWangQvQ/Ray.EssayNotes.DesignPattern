using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// 巧克力
    /// </summary>
    public class Chocolate : Decorator
    {
        public Chocolate(Coffee coffee) : base(coffee)
        {
            this.Desc = "巧克力";
            this.Price = 1;
        }
    }
}