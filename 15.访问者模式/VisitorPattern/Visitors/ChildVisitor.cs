using System;
using VisitorPattern.Elements;

namespace VisitorPattern.Visitors
{
    public class ChildVisitor:IVisitor
    {
        public ChildVisitor()
        {
        }

        public string Name => "小孩";

        public string Visit(ParkElement park)
        {
            return $"玩游戏";
        }

        public string Visit(BasketballCourtElement basketballCourt)
        {
            return $"打篮球";
        }
    }
}
