using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uhhh_yeah_this
{
    class Instructors
    {
        private string FirstName;
        private string LastName;
        private string CourseName;

        public Instructors(string teacherFirstName, string teacherLastName, string CourseName)
        {
            this.FirstName = teacherFirstName;
            this.LastName = teacherLastName;
            this.CourseName = CourseName;
        }
        public void SetStudentGrade(Student student, int grade)
        
        {
          
        }
        public void PrintNameAndCourse(string FirstName, string LastName, string CourseName)
        {
            System.Console.WriteLine(FirstName + " " + LastName + " And I teach" + CourseName + ".");

        }


    }
}
