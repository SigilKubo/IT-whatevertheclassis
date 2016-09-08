namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string blah = System.Console.ReadLine();
            //double blah = double.Parse(System.Console.Readline);

            
            System.Console.Write ("What is your first name?  :  ");
            string firstName = System.Console.ReadLine();

            System.Console.Write ("What is your middle initial?  :  ");
            string middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name?  :  ");
            string lastName = System.Console.ReadLine();

            System.Console.Write("Is this your full name?  :  ");
            string fullName = firstName + " " + middleInitial + ". " + lastName;
            System.Console.WriteLine(fullName);
            System.Console.WriteLine("===============================================");

            System.Console.Write("What is your height in Feet?  :  ");
            int heightinFeet;
            heightinFeet =  int.Parse(System.Console.ReadLine());
            System.Console.Write("What is the inches beyond your base height?  :  ");
            double extraInches;
            extraInches = double.Parse(System.Console.ReadLine());
            double heightInInches = heightinFeet * 12;
            double totalInches = heightInInches + extraInches;
            double heightInCM = totalInches * 2.54;
            System.Console.WriteLine("===============================================");
            int userAge;
            bool isCitizen;
            bool canVote;
            System.Console.WriteLine ("How old are you?  :  ");
            userAge = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine ("Are you a citizen of the United States?  :  ");
            isCitizen = bool.Parse(System.Console.ReadLine());
            canVote = userAge > 18 && isCitizen;

            System.Console.WriteLine("===============================================");
            System.Console.Write ("Full Name  :  ");
            System.Console.WriteLine(fullName);
            System.Console.Write ("Height in Centimeters  :  ");
            System.Console.WriteLine(heightInCM);
            System.Console.Write("Can you Vote? : ");
            System.Console.WriteLine(canVote);
            


        }
    }
}
