using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class OrganizationComponent
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Desc { get; set; }

        public OrganizationComponent(string name, string desc)
        {
            this.Name = name;
            this.Desc = desc;
        }

        /// <summary>
        /// 添加
        /// </summary>
        public virtual void Add(OrganizationComponent organizationComponent)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="organizationComponent"></param>
        public virtual void Remove(OrganizationComponent organizationComponent)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 打印
        /// </summary>
        public abstract void Print();
    }
}