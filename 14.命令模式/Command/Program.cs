using System;
using CommandPattern.Receivers;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //调用端
            var client = new RemoteController();

            //灯（接收者）
            var light = new Light();

            var command1 = new LightOnCmd(light);
            var command2 = new LightOffCmd(light);

            client.AddCommand(command1);
            client.AddCommand(command2);

            client.ExcuteCommands();

            Console.ReadLine();
        }
    }
}
