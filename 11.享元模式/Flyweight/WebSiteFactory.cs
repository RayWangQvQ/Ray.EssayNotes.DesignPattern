using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class WebSiteFactory
    {
        private Dictionary<string, ConcreteWebSite> _pool = new Dictionary<string, ConcreteWebSite>();

        public WebSite GetWebSiteCategory(string type)
        {
            if (!_pool.ContainsKey(type))
                _pool.Add(type, new ConcreteWebSite(type));

            return _pool.GetValueOrDefault(type);
        }
    }
}