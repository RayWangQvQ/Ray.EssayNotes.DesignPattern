using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter2
{
    /// <summary>
    /// 被适配类
    /// 三方插件已实现的方法
    /// </summary>
    public class Source
    {
        public void OutPut()
        {
            Console.WriteLine($"输出220V电压");
        }
    }
}