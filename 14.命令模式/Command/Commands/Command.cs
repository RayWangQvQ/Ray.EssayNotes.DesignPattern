using System;

namespace CommandPattern
{
    public interface ICommand
    {
        /// <summary>
        /// 执行命令
        /// </summary>
        void Excute();
    }
}
