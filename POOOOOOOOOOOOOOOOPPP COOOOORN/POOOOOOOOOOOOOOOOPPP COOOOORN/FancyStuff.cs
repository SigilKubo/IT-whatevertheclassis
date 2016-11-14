using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOOOOOOOOOOOOOOOPPP_COOOOORN
{
    class FancyStuff
    {
        public static void Typehere()
        {
            System.Console.WriteLine();
            System.Console.Write("  ===>  ");

        }
        public static void StoreClerk(string text)
        {
            System.Console.WriteLine();
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine(" " + text);
            System.Console.WriteLine();
            System.Console.Write(" ");
            System.Console.ResetColor();

        }

        public static void Question()

        {
            FancyStuff.StoreClerk(" Hi. Will this be a Matinee? ");

        }


        

        

        public static void Endencounter()
        {
            FancyStuff.StoreClerk(" Thank you for choosing This Terrible Code Cinema! ");
            Console.WriteLine("Press Any Key to continue...");
            System.Console.ReadKey();

        }
    }

}
