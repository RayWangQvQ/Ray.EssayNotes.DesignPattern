using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class ReporterBase
    {
        /// <summary>
        /// 播报当前图形的特性
        /// </summary>
        public abstract void Speak();
    }
}