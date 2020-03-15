using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class ShapeBase
    {
        /// <summary>
        /// 形状名称
        /// （抽象属性，由子类决定）
        /// </summary>
        public abstract string Name
        {
            get;
        }

        /// <summary>
        /// 画布大小
        /// </summary>
        protected int Size => 10;

        /// <summary>
        /// 准备绘制
        /// </summary>
        public void Prepare()
        {
            Console.WriteLine($"开始绘制{this.Name}：");
            Console.WriteLine();
        }

        /// <summary>
        /// 打印画图
        /// （抽象方法，由继承的子类更具自己具体是什么形状绘制）
        /// </summary>
        public abstract void Draw();

        /// <summary>
        /// 绘制结束
        /// </summary>
        public void End()
        {
            Console.WriteLine();
            Console.WriteLine($"绘制{this.Name}完成");
        }
    }
}