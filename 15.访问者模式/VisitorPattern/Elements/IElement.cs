using System;
using VisitorPattern.Visitors;

namespace VisitorPattern.Elements
{
    /// <summary>
    /// 定一个被访问的元素
    /// </summary>
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
