using System;
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
            Instructors John = new Instructors("John", "Fuckboy", "English");
            Instructors Mike = new Instructors("Mike", "Fuckboy", "Math");
            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);
            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);


        }
    }
}
