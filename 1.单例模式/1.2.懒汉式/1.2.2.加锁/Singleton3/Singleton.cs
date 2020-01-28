using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton3
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object syncObj = new object();
        private Singleton()
        {

        }

        //在首次获取单例对象时实例化
        public static Singleton GetInstance()
        {
            //判断前加线程锁，避免了多线程同时进入的情况
            lock (syncObj)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }

            return instance;
        }
    }
}
