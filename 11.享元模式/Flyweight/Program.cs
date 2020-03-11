using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var factory = new WebSiteFactory();

            WebSite webSite1 = factory.GetWebSiteCategory("新闻");
            webSite1.Use();

            WebSite webSite2 = factory.GetWebSiteCategory("博客");
            webSite2.Use();

            WebSite webSite3 = factory.GetWebSiteCategory("博客");
            webSite3.Use();
        }
    }
}
