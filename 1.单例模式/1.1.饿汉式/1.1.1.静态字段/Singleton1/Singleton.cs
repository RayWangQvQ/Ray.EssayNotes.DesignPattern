using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton1
{
    /// <summary>
    /// 单例类
    /// </summary>
    public class Singleton
    {
        //本类内部创建对象实例
        private static readonly Singleton instance = new Singleton();

        //构造函数要私有，避免外部调用实例化
        private Singleton()
        {

        }

        //提供一个共有的静态方法，返回实例对象
        public static Singleton GetInstance()
        {
            return instance;
        }
    }

}
