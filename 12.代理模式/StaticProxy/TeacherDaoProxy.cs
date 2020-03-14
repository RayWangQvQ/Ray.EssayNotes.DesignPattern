using System;
using System.Collections.Generic;
using System.Text;

namespace StaticProxy
{
    public class TeacherDaoProxy : ITeacherDao
    {
        private ITeacherDao _teacherDao;

        public TeacherDaoProxy(ITeacherDao teacherDao)
        {
            _teacherDao = teacherDao;
        }

        public void Teach()
        {
            Console.WriteLine("开始代理，可以做些其他的事情");
            _teacherDao.Teach();
            Console.WriteLine("结束代理，可以做些其他的事情");
        }
    }
}