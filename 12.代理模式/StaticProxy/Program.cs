using System;

namespace StaticProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ITeacherDao teacherDaoProxy = new TeacherDaoProxy(new TeacherDao());

            teacherDaoProxy.Teach();

            Console.ReadKey();
        }
    }
}
