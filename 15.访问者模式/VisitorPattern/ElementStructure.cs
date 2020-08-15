using System;
using System.Collections.Generic;
using VisitorPattern.Elements;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    /// <summary>
    ///维护元素集合
    /// </summary>
    public class ElementStructure
    {
        private List<IElement> _elements = new List<IElement>();

        public void AddElement(IElement element)
        {
            this._elements.Add(element);
        }

        public void RemoveElement(IElement element)
        {
            this._elements.Remove(element);
        }

        public void AcceptVisitor(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
