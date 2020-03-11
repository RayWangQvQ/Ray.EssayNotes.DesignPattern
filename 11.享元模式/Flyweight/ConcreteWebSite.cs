using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class ConcreteWebSite : WebSite
    {
        private string _type;
        public ConcreteWebSite(string type)
        {
            this._type = type;
        }

        public override void Use()
        {
            Console.WriteLine($"{_type}正在使用...");
        }
    }
}