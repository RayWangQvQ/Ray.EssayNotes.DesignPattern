using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class HuaWei : Brand
    {
        public void Call()
        {
            Console.WriteLine("华为手机打电话");
        }

        public void Close()
        {
            Console.WriteLine("华为手机关机");
        }

        public void Open()
        {
            Console.WriteLine("华为手机开机");
        }
    }
}