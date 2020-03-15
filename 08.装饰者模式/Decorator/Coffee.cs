using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// 抽象基类
    /// </summary>
    public abstract class Coffee
    {
        public virtual string Desc { get; set; }

        public virtual float Price { get; set; }
    }
}