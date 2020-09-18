using System;

namespace Macek_assignment1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your personal age calculator");
            Console.WriteLine("Please provide me with your details");

            Console.Write("First Name: ");
            string firstName = (Console.ReadLine());

            Console.Write("Last Name: ");
            string lastName = (Console.ReadLine());

            Console.Write("City: ");
            string city = (Console.ReadLine());

            Console.Write("Country: ");
            string country = (Console.ReadLine());

            Console.Write("Date of birth (DD-MM-YY): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);


            Console.WriteLine("*********** Here are your details ***********");


            // calling different class
            AgeCounter agecounter  = new AgeCounter();


            agecounter.GetMyInformation(firstName, lastName, city, country, dob);

            Console.WriteLine("*********************************************");
            Console.WriteLine("*********** Here are your numbers ***********");
            
            Console.WriteLine($"Your approximate age in days: {agecounter.DaysPassedSinceYourBirth(dob)}");

            Console.WriteLine($"Your approximate age in hours: {agecounter.HoursPassedSinceYourBirth(dob)}");

            Console.WriteLine($"Your approximate age in minutes: {agecounter.MinutesPassedSinceYourBirth(dob)}");

            Console.WriteLine($"Your approximate age in seconds: {agecounter.SecondsPassedSinceYourBirth(dob)}");

            Console.WriteLine("***************** Thank you *****************");
        }
    }

}
