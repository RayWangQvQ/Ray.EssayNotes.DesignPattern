using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter2
{
    /// <summary>
    /// 适配器
    /// </summary>
    public class ClassAdapter : ITarget
    {
        public Source Source;

        public ClassAdapter()
        {
            Source = new Source();
        }


        public void Charging()
        {
            Source.OutPut();
            Console.WriteLine("转换中......");
            Console.WriteLine("输出5V电压");
        }
    }
}