using System;
namespace CommandPattern.Receivers
{
    /// <summary>
    /// 电灯
    /// </summary>
    public class Light
    {
        public Light()
        {
        }

        /// <summary>
        /// 打开
        /// </summary>
        public void On()
        {
            Console.WriteLine("电灯打开了");
        }

        /// <summary>
        /// 关闭
        /// </summary>
        public void Off()
        {
            Console.WriteLine("电灯关闭了");
        }
    }
}
