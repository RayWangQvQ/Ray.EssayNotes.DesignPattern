using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 学院
    /// </summary>
    public class College : OrganizationComponent
    {
        public List<OrganizationComponent> OrganizationComponents = new List<OrganizationComponent>();

        public College(string name, string desc) : base(name, desc)
        {

        }

        public override void Add(OrganizationComponent organizationComponent)
        {
            OrganizationComponents.Add(organizationComponent);
        }

        public override void Remove(OrganizationComponent organizationComponent)
        {
            OrganizationComponents.Remove(organizationComponent);
        }


        public override void Print()
        {
            Console.WriteLine($"—— 学院：{this.Name}");
            foreach (var item in this.OrganizationComponents)
            {
                item.Print();
            }
        }
    }
}