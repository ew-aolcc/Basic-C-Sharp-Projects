using System;

namespace BooleanLogic{
    class Program{
        static void Main(string[] args){
            // Print the application title to the console
            Console.WriteLine("Car Insurance Application");

            // Ask for the driver age and convert the input string to an integer
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask if the driver has had a DUI,
            // convert input to lowercase, and check if it equals "yes"
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower();
            bool dui = answer == "yes";

            // Ask for the number of speeding tickets.
            // convert the input string to an integer
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Evaluate rules: over 15 years old, no DUIs, and 3 or fewer speeding tickets
            Console.WriteLine("Qualified for insurance?");
            bool qualified = (age > 15) && !dui && (tickets <= 3);

            // Print the boolean result (True or False)
            Console.WriteLine(qualified);
        }
    }
}