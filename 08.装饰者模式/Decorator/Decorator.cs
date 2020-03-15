using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// 装饰者基类
    /// </summary>
    public abstract class Decorator : Coffee
    {
        /// <summary>
        /// 聚合进被装饰者
        /// </summary>
        private Coffee _coffee;
        public Decorator(Coffee coffee)
        {
            this._coffee = coffee;
        }

        public override string Desc
        {
            get => $"{_coffee.Desc}+{base.Desc}";//重写：当前装饰者内容 + 被装饰者原有内容
            set => base.Desc = value;
        }
        public override float Price
        {
            get => _coffee.Price + base.Price;//重写：当前装饰者内容 + 被装饰者原有内容
            set => base.Price = value;
        }
    }
}