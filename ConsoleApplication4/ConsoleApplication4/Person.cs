namespace ConsoleApplication4
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public int Age;
        public static int OfPeople;
        public static int SumOfAllAges;

        public static double AverageAgeOfEveryone()
        {
            return Person.SumOfAllAges / Person.OfPeople;

        }



        public void InformationNeeded()
        {
            System.Console.Write("First Name:   ");
            FirstName = System.Console.ReadLine();

            System.Console.Write("Last Name:    ");
            LastName = System.Console.ReadLine();

            System.Console.Write("Age:          ");
            Age = int.Parse(System.Console.ReadLine());

            Person.OfPeople++;
            Person.SumOfAllAges += Age;

        }
        public void SpouseInformation()
        {
            this.Spouse = new Person();

            System.Console.Write("Spouse Name:  ");
            Spouse.FirstName = System.Console.ReadLine();

            System.Console.Write("Spouse Age:   ");
            Spouse.Age = int.Parse(System.Console.ReadLine());

            Person.OfPeople++;
            Person.SumOfAllAges += Age;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        

        }
        public string GetSpouseFullName()
        {
            return Spouse.FirstName + " " + this.LastName;

        }
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine ("{"this.Age"}");
            System.Console.WriteLine(this.GetSpouseFullName());
            System.Console.WriteLine("{"this.Spouse.Age"}");



        }

        
    }
}
