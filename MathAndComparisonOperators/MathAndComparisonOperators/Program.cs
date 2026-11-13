using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the title of the program to the console
            Console.WriteLine("Anonymous Income Comparison Program");

            // Gather details for Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine();

            // Calculate annual salary for Person 1 (Hourly rate * Hours per week * 52 weeks)
            // Conver to Int
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;

            // Gather details for Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();

            // Calculate annual salary for Person 2 (Hourly rate * Hours per week * 52 weeks)
            // Conver to Int
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;

            // Print Annual salary of Person 1
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);

            // Print Annual salary of Person 2
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);

            // Compare salaries and print whether Person 1 makes more money than Person 2 (true/false)
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = salary1 > salary2;
            Console.WriteLine(isMore);

            // Keep console open until a key is pressed
            Console.ReadLine();
        }
    }
}