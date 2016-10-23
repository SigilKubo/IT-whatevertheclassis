using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uhhh_yeah_this
{
    class Instructor
    {
        private string FirstName;
        private string CourseName;

        public string GetNameandCourse()
        { return this.FirstName + " who teaches " + this.CourseName + ".   ";
        }
////////////////////////////////////////////////////////////////////////
        public Instructor(string teacherFirstName, string courseName)
        {
            this.FirstName = teacherFirstName;
            this.CourseName = courseName;
        }
        public void SetStudentGrade(Student student, int ggrade)
        {
            student.SetGrade(ggrade);
        }
/// /////////////////////////////////////////////////////////////////

        public void PrintNameAndCourse()
        {
         System.Console.WriteLine(GetNameandCourse());
        }


    }
}
