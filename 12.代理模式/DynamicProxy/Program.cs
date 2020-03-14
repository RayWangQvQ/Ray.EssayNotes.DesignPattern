using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ITeacherDao teacherDao = new TeacherDao();

            ITeacherDao teacherDaoProxy = ProxyFactory<ITeacherDao>.Create(teacherDao);

            teacherDaoProxy.Teach();

            Console.ReadLine();
        }
    }
}
