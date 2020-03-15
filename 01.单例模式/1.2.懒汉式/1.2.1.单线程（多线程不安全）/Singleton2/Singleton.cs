using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton2
{
    public class Singleton
    {
        private static Singleton instance;
        private Singleton()
        {

        }

        //在首次获取单例对象时实例化
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
