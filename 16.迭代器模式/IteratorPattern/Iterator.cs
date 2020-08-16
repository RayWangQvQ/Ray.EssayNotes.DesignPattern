using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorPattern
{
    /// <summary>
    /// 抽象迭代器
    /// </summary>
    public interface IIterator
    {
        bool HasNext();

        object First();

        object Next();
    }

    /// <summary>
    /// 具体迭代器
    /// </summary>
    public class ConcreteIterator : IIterator
    {
        private List<object> _list;
        private int _index=-1;

        public ConcreteIterator(List<object> list)
        {
            _list = list;
        }

        public bool HasNext()
        {
            return _index < _list.Count-1;
        }

        public object First()
        {
            return _list.First();
        }

        public object Next()
        {
            if (HasNext()) return _list[++_index];
            return null;
        }
    }
}
