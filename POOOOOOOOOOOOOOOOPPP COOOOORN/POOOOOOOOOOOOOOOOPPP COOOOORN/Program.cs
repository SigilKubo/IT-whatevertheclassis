using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOOOOOOOOOOOOOOOPPP_COOOOORN
{
    class Program
    {
        static void Main(string[] args)
        {
            FancyStuff.Question();
            FancyStuff.Typehere();

            string Answer = System.Console.ReadLine();

            if (Answer.ToLower().Contains("morning") || Answer.ToLower().Contains("daytime"))
            {

                FancyStuff.StoreClerk("Okay, A daytime movie, that's great!");
                FancyStuff.StoreClerk("Will you be bringing any kids?");
                FancyStuff.Typehere();
                int NumberofKids = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("All right. How Many Adults?");
                FancyStuff.Typehere();
                int NumberofAdults = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("And Lastly, Seniors?");
                FancyStuff.Typehere();
                int NumberofSeniors = int.Parse(System.Console.ReadLine());

                int TotalNumberofParty = NumberofKids + NumberofAdults + NumberofSeniors;
                double CostOfKidsTickets = NumberofKids * 3.99;
                double CostOfAdultTickets = NumberofAdults * 5.99;
                double CostofSeniorTickets = NumberofSeniors * 4.50;
                double CostOfTotalTickets = CostOfKidsTickets + CostofSeniorTickets + CostOfAdultTickets;

                FancyStuff.StoreClerk("Okay. So far, I have " + NumberofKids + " kids, " + NumberofAdults + " adults, and " + NumberofSeniors + " seniors.");
                FancyStuff.StoreClerk("Cool. What would you be having today to eat?");
                FancyStuff.StoreClerk("Would you like a small Soda?");
                int NumberofSmallSoda = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("Prefer a large Soda");
                int NumberofLargeSoda = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("Okay. Now for food. Would you like a hotdog?");
                int NumberOfHotdog = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("All right. What about some popcorn?");
                int NumberofPopcorn = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("Lastly, would you like some candy?");
                int NumberofCandies = int.Parse(System.Console.ReadLine());



            }

            else if (Answer.ToLower().Contains("night") || Answer.ToLower().Contains("evening"))
                {


            }
                

            
            else
            {
                FancyStuff.StoreClerk("I don't believe that was what I asked...");
            }


        }
    }
}
