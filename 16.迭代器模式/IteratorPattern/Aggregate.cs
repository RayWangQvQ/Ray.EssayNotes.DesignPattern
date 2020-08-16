using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    /// <summary>
    /// 抽象聚合
    /// </summary>
    public interface IAggregate
    {
        void Add(object ob);

        void Remove(object ob);

        IIterator GetIterator();
    }

    public class ConcreteAggregate : IAggregate
    {
        private List<object> _list=new List<object>();

        public void Add(object ob)
        {
            _list.Add(ob);
        }

        public void Remove(object ob)
        {
            _list.Remove(ob);
        }

        public IIterator GetIterator()
        {
            return new ConcreteIterator(_list);
        }
    }
}
