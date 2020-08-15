using System;
using CommandPattern.Receivers;

namespace CommandPattern
{
    /// <summary>
    /// 关灯命令
    /// </summary>
    public class LightOffCmd:ICommand
    {
        /// <summary>
        /// 电灯
        /// </summary>
        private readonly Light _light;

        public LightOffCmd(Light light)
        {
            _light = light;
        }

        public void Excute()
        {
            _light.Off();
        }
    }
}
