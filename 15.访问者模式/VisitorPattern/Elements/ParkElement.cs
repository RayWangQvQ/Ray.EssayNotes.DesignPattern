using System;
using VisitorPattern.Visitors;

namespace VisitorPattern.Elements
{
    /// <summary>
    /// 公园
    /// </summary>
    public class ParkElement:IElement
    {
        public ParkElement()
        {
        }

        public void Accept(IVisitor visitor)
        {
            string result = visitor.Visit(this);
            Console.WriteLine($"{visitor.Name}访问公园，并开始{result}") ;
        }
    }
}
