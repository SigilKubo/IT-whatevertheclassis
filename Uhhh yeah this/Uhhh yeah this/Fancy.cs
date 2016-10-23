using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uhhh_yeah_this
{
    class Fancy
    {
        public static void Title()
        {
            System.Console.WriteLine("I actually hate this class.");
        }
        public static void SpaceDivider()
        {
            System.Console.WriteLine("     ");
        }
        public static void Divider()
        {
            System.Console.WriteLine("x======================================================================x");
        }
        public static void Studentinfo(string sssstudent, int ggrrade, Instructor TTeacher)
        {
            Fancy.Borderone("   Hi. My name is " + sssstudent + ". My teacher is Mr. " + TTeacher.GetNameandCourse());
            Fancy.Bordertwo("   I have a " + ggrrade + " in the course.");
        }
        public static void Borderone(string Boorder)
        {
            System.Console.WriteLine("I" + Boorder.PadRight(70) + "I");       
        }
        public static void Bordertwo(string Booorder)
        {
            System.Console.WriteLine("I" + Booorder.PadRight(70) + "I");
        }
            
    }
}
