using System;
namespace Macek_assignment1
{
    public class AgeCounter
    {
        //public string firstName;

        public void GetMyInformation(string firstName, string lastName, string city, string country,DateTime dob)
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($" City: {city}");
            Console.WriteLine($" Country: {country}");
            Console.WriteLine($" Date of birth: {dob}");
        }

        public int DaysPassedSinceYourBirth(DateTime dob)
        {
            TimeSpan timeSpan = DateTime.Now - dob;
            int totalDays = timeSpan.Days;
            return totalDays;
        }

        public double HoursPassedSinceYourBirth(DateTime dob)
        {
            double timeSpanHours = (DateTime.Now - dob).TotalHours;
            return timeSpanHours;
        }

        public double MinutesPassedSinceYourBirth(DateTime dob)
        {
            double timeSpanMinutes = (DateTime.Now - dob).TotalMinutes;
            return timeSpanMinutes;
        }

        public double SecondsPassedSinceYourBirth(DateTime dob)
        {
            double timeSpanSeconds = (DateTime.Now - dob).TotalSeconds;
            return timeSpanSeconds;
        }
    }
}
