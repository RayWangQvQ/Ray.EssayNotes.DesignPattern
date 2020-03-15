using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// 适配器
    /// </summary>
    public class ClassAdapter : Source, ITarget
    {
        public void Charging()
        {
            this.OutPut();
            Console.WriteLine("转换中......");
            Console.WriteLine("输出5V电压");
        }
    }
}