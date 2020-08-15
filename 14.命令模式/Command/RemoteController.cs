using System;
using System.Collections.Generic;

namespace CommandPattern
{
    /// <summary>
    /// 遥控器
    /// </summary>
    public class RemoteController
    {
        private List<ICommand> _commands = new List<ICommand>();

        /// <summary>
        /// 添加命令
        /// </summary>
        /// <param name="command"></param>
        public void AddCommand(ICommand command)
        {
            this._commands.Add(command);
        }

        /// <summary>
        /// 执行所有命令
        /// </summary>
        public void ExcuteCommands()
        {
            foreach (var item in _commands)
            {
                item.Excute();
            }
        }
    }
}
