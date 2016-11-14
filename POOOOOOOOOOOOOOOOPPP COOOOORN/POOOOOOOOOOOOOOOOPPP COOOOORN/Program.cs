namespace POOOOOOOOOOOOOOOOPPP_COOOOORN
{
    class Program
    {
        static void Main(string[] args)
        {
            FancyStuff.Question();
            FancyStuff.Typehere();

            string Answer = System.Console.ReadLine();
            bool isMatinee = Answer.ToLower().Contains("y");

                FancyStuff.StoreClerk("Okay that's great!");
                FancyStuff.StoreClerk("How many Children?");
                FancyStuff.Typehere();
                int NumberofKids = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("All right. How Many Adults?");
                FancyStuff.Typehere();
                int NumberofAdults = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("And Lastly, Seniors?");
                FancyStuff.Typehere();
                int NumberofSeniors = int.Parse(System.Console.ReadLine());

                int TotalNumberofParty = NumberofKids + NumberofAdults + NumberofSeniors;
                double PriceOfKidsTickets = isMatinee ? 3.99:6.99;
                double PriceOfAdultTickets = isMatinee ? 5.99:10.99;
                double PriceofSeniorTickets = isMatinee ? 4.50:8.50;
            double CostOfKidsTickets = PriceOfKidsTickets * NumberofKids;
                double CostOfAdultTickets = PriceOfAdultTickets * NumberofAdults;
            double CostofSeniorTickets = PriceofSeniorTickets * NumberofSeniors;

                double CostOfTotalTickets = CostOfKidsTickets + CostofSeniorTickets + CostOfAdultTickets;
                

                FancyStuff.StoreClerk("Okay. So far, I have " + NumberofKids + " kids, " + NumberofAdults + " adults, and " + NumberofSeniors + " seniors.");
                FancyStuff.StoreClerk("Cool. Now for Concessions.");
                FancyStuff.StoreClerk("How many small Sodas?");
                FancyStuff.Typehere();
                int NumberofSmallSoda = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("How many large Sodas?");
                FancyStuff.Typehere();
                int NumberofLargeSoda = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("Okay. Now for food. How many hotdogs?");
                FancyStuff.Typehere();
                int NumberOfHotdog = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("All right. How many popcorns?");
                FancyStuff.Typehere();
                int NumberofPopcorn = int.Parse(System.Console.ReadLine());
                FancyStuff.StoreClerk("Lastly, how many candies?");
                FancyStuff.Typehere();
                int NumberofCandies = int.Parse(System.Console.ReadLine());

            double CostofSmallSodas = NumberofSmallSoda * 3.50;
            double CostofLargeSodas = NumberofLargeSoda * 5.99;
            double CostofHotdogs = NumberOfHotdog * 3.99;
            double CostofPopcorns = NumberofPopcorn * 4.50;
            double CostofCandies = NumberofCandies * 1.99;
            int minofConcessions = NumberofPopcorn < NumberofLargeSoda ? NumberofPopcorn : NumberofLargeSoda;
            int Miningeneral = minofConcessions < TotalNumberofParty ? minofConcessions : TotalNumberofParty;


            double CostofAllConcessions = CostofSmallSodas + CostofLargeSodas + CostofHotdogs + CostofPopcorns + CostofCandies;

            double DiscountofCandies = NumberofCandies / 4 * 1.99;
            CostofAllConcessions = CostofAllConcessions - DiscountofCandies;

                if (TotalNumberofParty  > 4 && NumberofPopcorn > 1 && isMatinee == false )
                {
                 CostofAllConcessions = CostofPopcorns - 4.50;

                }
                
                if (NumberofPopcorn >= 1 && NumberofLargeSoda >=1)
            { 
                double MovieTicketDiscount = Miningeneral * 2.00;
                CostOfTotalTickets = CostOfTotalTickets - MovieTicketDiscount;
                    
            }
            double TotalCostInGeneral = CostofAllConcessions + CostOfTotalTickets;
            FancyStuff.StoreClerk(" With everything so far....... ");
                FancyStuff.StoreClerk(" I have you for a grand total of " + TotalCostInGeneral + ".");
           
                
            FancyStuff.Endencounter();

        }
    }
}
