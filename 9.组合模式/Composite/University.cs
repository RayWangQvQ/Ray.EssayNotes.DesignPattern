using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 大学
    /// </summary>
    public class University : OrganizationComponent
    {
        public List<OrganizationComponent> OrganizationComponents = new List<OrganizationComponent>();

        public University(string name, string desc) : base(name, desc)
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
            Console.WriteLine($"— 大学：{this.Name}");
            foreach (var item in this.OrganizationComponents)
            {
                item.Print();
            }
        }
    }
}