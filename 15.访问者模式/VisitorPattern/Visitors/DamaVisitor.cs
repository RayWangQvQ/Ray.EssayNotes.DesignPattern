using System;
using VisitorPattern.Elements;

namespace VisitorPattern.Visitors
{
    public class DamaVisitor:IVisitor
    {
        public DamaVisitor()
        {
        }

        public string Name => "大妈";

        public string Visit(ParkElement park)
        {
            return $"跳广场舞";
        }

        public string Visit(BasketballCourtElement basketballCourt)
        {
            return $"跳篮球场舞";
        }
    }
}
