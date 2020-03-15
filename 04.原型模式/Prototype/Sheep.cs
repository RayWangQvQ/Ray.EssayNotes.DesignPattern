using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Prototype
{
    /// <summary>
    /// 羊
    /// </summary>
    public class Sheep
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public SheepColor Color { get; set; }

        /// <summary>
        /// 浅拷贝
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            //MemberwiseClone方法实现浅拷贝
            return this.MemberwiseClone();
        }

        /// <summary>
        /// 深拷贝
        /// </summary>
        /// <returns></returns>
        public object DeepClone()
        {
            string str = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<Sheep>(str);
        }
    }

    public class SheepColor
    {
        /// <summary>
        /// 颜色编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 颜色名称
        /// </summary>
        public string Name { get; set; }
    }
}