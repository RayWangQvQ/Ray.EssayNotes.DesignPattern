using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class FoldedPhone : Phone
    {
        public FoldedPhone(Brand brand) : base(brand)
        {

        }

        public override void Open()
        {
            base.Open();
            Console.WriteLine("折叠式手机");
        }

        public override void Call()
        {
            base.Call();
            Console.WriteLine("折叠式手机");
        }

        public override void Close()
        {
            base.Close();
            Console.WriteLine("折叠式手机");
        }
    }
}