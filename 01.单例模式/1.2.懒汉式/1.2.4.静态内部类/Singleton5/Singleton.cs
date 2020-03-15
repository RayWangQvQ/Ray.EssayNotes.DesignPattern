using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton5
{
    public class Singleton
    {
        private Singleton()
        {

        }

        //在首次获取单例对象时实例化
        public static Singleton GetInstance()
        {
            return Nested.instance;
        }

        /// <summary>
        /// 静态内部类
        /// （不会被实例化，且只有当被使用的时候才会执行类内对应代码）
        /// </summary>
        private static class Nested
        {
            internal static readonly Singleton instance = new Singleton();
            static Nested()
            {

            }
        }
    }
}
