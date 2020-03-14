using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicProxy
{
    public class ProxyFactory<T>
    {
        public static T Create(T obj)
        {
            var proxy = new DynamicProxy<T>(obj);

            return (T)proxy.GetTransparentProxy();
        }
    }
}