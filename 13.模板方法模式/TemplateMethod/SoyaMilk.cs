using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class SoyaMilk
    {
        /// <summary>
        /// 制作
        /// </summary>
        public virtual void Make()
        {
            Select();
            Add();
            Soak();
            Beat();
        }

        /// <summary>
        /// 准备黄豆
        /// </summary>
        public void Select()
        {
            Console.WriteLine("第一步：选好黄豆");
        }

        /// <summary>
        /// 添加配料
        /// （由子类决定具体添加什么）
        /// </summary>
        public abstract void Add();

        /// <summary>
        /// 浸泡
        /// </summary>
        public void Soak()
        {
            Console.WriteLine("第三步：浸泡");
        }

        /// <summary>
        /// 放入豆浆机打碎
        /// </summary>
        public void Beat()
        {
            Console.WriteLine("第四步：放入豆浆机打碎");
        }

    }
}