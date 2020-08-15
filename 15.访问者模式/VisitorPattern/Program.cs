using System;
using VisitorPattern.Elements;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var elementStructure = new ElementStructure();
            elementStructure.AddElement(new ParkElement());
            elementStructure.AddElement(new BasketballCourtElement());

            IVisitor visitor1 = new ChildVisitor();
            elementStructure.AcceptVisitor(visitor1);

            IVisitor visitor2 = new DamaVisitor();
            elementStructure.AcceptVisitor(visitor2);

            Console.ReadLine();
        }
    }
}
