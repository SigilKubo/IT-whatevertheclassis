﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uhhh_yeah_this
{
    class Program
    {
        static void Main(string[] args)
        {
            Fancy.Title();
            Fancy.SpaceDivider();

            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");
            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);
            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            Fancy.Divider();
            Jane.PrintAllInformation();
            Fancy.Divider();
            Joe.PrintAllInformation();
            Fancy.Divider();
            Melissa.PrintAllInformation();
            Fancy.Divider();
            Matt.PrintAllInformation();
            Fancy.Divider();

            Fancy.SpaceDivider();

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
