using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class XiaoMi : Brand
    {
        public void Call()
        {
            Console.WriteLine("小米手机打电话");
        }

        public void Close()
        {
            Console.WriteLine("小米手关机");

        }

        public void Open()
        {
            Console.WriteLine("小米手机开机");

        }
    }
}