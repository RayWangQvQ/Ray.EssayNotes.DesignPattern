using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 系
    /// </summary>
    public class Department : OrganizationComponent
    {
        public Department(string name, string desc) : base(name, desc)
        {

        }

        public override void Print()
        {
            Console.WriteLine($"——— 院系：{this.Name}");
        }
    }
}