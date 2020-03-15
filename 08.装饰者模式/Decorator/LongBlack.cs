using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// 黑咖啡
    /// </summary>
    public class LongBlack : Coffee
    {
        public LongBlack()
        {
            this.Desc = "黑咖啡";
            this.Price = 5;
        }
    }
}