using System;
using System.Collections.Generic;
using System.Text;

namespace StaticProxy
{
    public class TeacherDao : ITeacherDao
    {
        public void Teach()
        {
            Console.WriteLine("开始教学");
        }
    }
}