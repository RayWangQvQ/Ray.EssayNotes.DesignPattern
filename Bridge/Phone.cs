using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Phone
    {
        private Brand Brand;

        public Phone(Brand brand)
        {
            this.Brand = brand;
        }

        public virtual void Open()
        {
            this.Brand.Open();
        }

        public virtual void Call()
        {
            this.Brand.Call();
        }

        public virtual void Close()
        {
            this.Brand.Close();
        }
    }
}