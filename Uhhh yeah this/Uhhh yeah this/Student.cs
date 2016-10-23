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
        private Instructor Teacher;
//////////////////////////////////////////////////////
        public int getgrade()
        {
            return this.Grade;
        }
       public void SetGrade(int x)
        { 
            this.Grade = x;
        }

        public Student()
        {
            Grade = 0;
        }
  /////////////////////////////////////////////////////////////////////////////////////////////////////      
        public Student(string name, Instructor theTeacher)
        {
            this.Name = name;
            this.Teacher = theTeacher;
        }
        public void PrintAllInformation()

        {
            Fancy.Studentinfo(this.Name, this.Grade, this.Teacher);
                }

    }
}
