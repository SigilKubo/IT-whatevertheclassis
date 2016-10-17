using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uhhh_yeah_this
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructors Teacher;
       
       
        public void SetGrade(Instructors Teach, int SetGrade )
        {


        }
        public Student()
        {
            Grade = 0;

        }
        
        public Student(string Name, Instructors theTeacher)
        {

            this.Name = Name;
            this.Teacher = theTeacher;
        }
     
    }
}
