using System;
using VisitorPattern.Visitors;

namespace VisitorPattern.Elements
{
    public class BasketballCourtElement:IElement
    {
        public BasketballCourtElement()
        {
        }

        public void Accept(IVisitor visitor)
        {
            string result = visitor.Visit(this);
            Console.WriteLine($"{visitor.Name}访问篮球场，并开始{result}");
        }
    }
}
