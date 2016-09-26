using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        { Person p1 = new Person();
            Person p2 = new Person();

            System.Console.WriteLine("(======Information on p1======)");
            System.Console.WriteLine("                               ");

            p1.InformationNeeded();
            p1.SpouseInformation();

            System.Console.WriteLine("                               ");

            System.Console.WriteLine("(======Information on p2======)");
            System.Console.WriteLine("                               ");

            p2.InformationNeeded();
            p2.SpouseInformation();

            System.Console.WriteLine("                               ");

            System.Console.WriteLine("(======Summary======)");
            System.Console.WriteLine("                               ");

            p1.PrintNameAndAge();
            p2.PrintNameAndAge();

            System.Console.WriteLine("                               ");


            System.Console.WriteLine("Average Age = " + Person.AverageAgeOfEveryone());

        }
    }
}
