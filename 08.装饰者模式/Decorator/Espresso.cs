using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// 意大利咖啡
    /// </summary>
    public class Espresso : Coffee
    {
        public Espresso()
        {
            this.Desc = "意大利咖啡";
            this.Price = 6;
        }
    }
}