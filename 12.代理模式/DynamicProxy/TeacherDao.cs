using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicProxy
{
    public class TeacherDao : MarshalByRefObject, ITeacherDao
    {
        public void Teach()
        {
            Console.WriteLine("教学中");
        }
    }
}