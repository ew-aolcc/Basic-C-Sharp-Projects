using System;

namespace PackageExpress{
    class Program{
        static void Main(string[] args){
            // Display the welcome message.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight.
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the package weight exceeds 50.
            // Display error message and end the program.
            if (weight > 50){
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt the user for the package width.
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the package height.
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // Requirement 6: Prompt the user for the package length.
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Calculate the sum of the dimensions and check if the total exceeds 50
            // Display error message and end the program.
            if ((width + height + length) > 50){
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Compute the product.
            double product = height * width * length;

            // Divide product by 100.
            double quote = (product * weight) / 100;

            // Display the quote formatted to two decimal places as currency
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}