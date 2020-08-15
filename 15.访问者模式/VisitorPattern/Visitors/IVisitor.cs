using System;
using VisitorPattern.Elements;

namespace VisitorPattern.Visitors
{
    /// <summary>
    /// 抽象访问者
    /// </summary>
    public interface IVisitor
    {
        string Name { get; }

        /// <summary>
        /// 访问公园
        /// </summary>
        /// <param name="park"></param>
        string Visit(ParkElement park);

        /// <summary>
        /// 访问篮球场
        /// </summary>
        /// <param name="basketballCourt"></param>
        string Visit(BasketballCourtElement basketballCourt);
    }
}
