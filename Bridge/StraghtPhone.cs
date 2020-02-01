using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class StraghtPhone : Phone
    {
        public StraghtPhone(Brand brand) : base(brand)
        {
        }

        public override void Call()
        {
            base.Call();
            Console.WriteLine("直板式手机");
        }

        public override void Close()
        {
            base.Close();
            Console.WriteLine("直板式手机");
        }

        public override void Open()
        {
            base.Open();
            Console.WriteLine("直板式手机");
        }
    }
}