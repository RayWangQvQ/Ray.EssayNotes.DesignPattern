using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton4
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
            //判断前不加线程锁
            if (instance == null)
            {
                //判断后再加锁，避免不是首次调用的情况下，每个线程都要加锁都要排队的效率浪费
                lock (syncObj)
                {
                    //双重判断，如果是首次调用，避免多线程重复创建
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }

            }

            return instance;
        }
    }
}
