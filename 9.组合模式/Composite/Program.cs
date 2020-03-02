using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //创建大学
            OrganizationComponent university = new University("布鲁弗莱大学", "学挖掘机，到布鲁佛莱！");

            //创建学院
            OrganizationComponent computerCollege = new College("计算机学院", "这是计算机学院的简介");
            university.Add(computerCollege);
            OrganizationComponent infoEngineerCollege = new College("信息工程学院", "这是信息工程学院的简介");
            university.Add(infoEngineerCollege);

            //创建专业（系）
            OrganizationComponent department1 = new Department("计算机科学与技术系", "这是计算机科学与技术系的简介");
            OrganizationComponent department2 = new Department("软件工程系", "这是软件工程系的简介");
            computerCollege.Add(department1);
            computerCollege.Add(department2);
            OrganizationComponent departmentA = new Department("通信工程系", "这是通信工程系的简介");
            OrganizationComponent departmentB = new Department("信息工程系", "这是信息工程系的简介");
            infoEngineerCollege.Add(departmentA);
            infoEngineerCollege.Add(departmentB);


            university.Print();
            //computerCollege.Print();
            //department1.Print();

            Console.ReadLine();
        }
    }
}
