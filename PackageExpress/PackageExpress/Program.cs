using System;

namespace PackageExpress{
    class Program{
        static void Main(string[] args){
            // Display the welcome message.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight.
            double weight = ConvertToDouble("Please enter the package weight:");

            // Check if the package weight exceeds 50.
            // Display error message and end the program.
            if (weight > 50){
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt the user for the package width.
            double width = ConvertToDouble("Please enter the package width:");

            // Prompt the user for the package height.
            double height = ConvertToDouble("Please enter the package height:");

            // Prompt the user for the package length.
            double length = ConvertToDouble("Please enter the package length:");

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

            // Display the quote formatted to two decimal places as currency.
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }

        // using double.TryParse instead of Convert.ToDouble,
        // so the program doesn’t crash if someone types letters instead of a number
        static double ConvertToDouble(string str) {
            Console.WriteLine(str);

            double result;

            while (!double.TryParse(Console.ReadLine(), out result)){
                Console.WriteLine("**Invalid input**. Please enter a valid number.");
                Console.WriteLine(str);
            }

            return result;
        }
    }
}