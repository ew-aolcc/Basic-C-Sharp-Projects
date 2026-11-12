using System;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // =========================================================================
            // Takes an input from the user that can handle 10,000,000 or larger.
            // multiplies it by 50.
            // =========================================================================
            Console.Write("Enter a large: ");
            string input1 = Console.ReadLine();
            // Convert input to a long to handle large numbers
            long number1 = Convert.ToInt64(input1);
            long product = number1 * 50;
            Console.WriteLine($"Result: {number1} * 50 = {product}\n");

            // =========================================================================
            // Takes an input from the user, adds 25 to it.
            // =========================================================================
            Console.Write("Enter a number to add 25 to: ");
            string input2 = Console.ReadLine();
            // Convert string input to a double
            double number2 = Convert.ToDouble(input2);
            double sum = number2 + 25;
            Console.WriteLine($"Result: {number2} + 25 = {sum}\n");

            // =========================================================================
            // Takes an input from the user, divides it by 12.5.
            // =========================================================================
            Console.Write("Enter a number to divide by 12.5: ");
            string input3 = Console.ReadLine();
            // Convert string input to a double
            double number3 = Convert.ToDouble(input3);
            double quotient = number3 / 12.5;
            Console.WriteLine($"Result: {number3} / 12.5 = {quotient}\n");

            // =========================================================================
            // Takes an input from the user, and check it is greater than 50.
            // =========================================================================
            Console.Write("Enter a number to check if it is greater than 50: ");
            string input4 = Console.ReadLine();
            // Convert string input to a double.
            double number4 = Convert.ToDouble(input4);
            // use bool for comparison operator.
            bool isGreaterThan50 = number4 > 50;
            Console.WriteLine($"Is {number4} greater than 50? {isGreaterThan50}\n");

            // =========================================================================
            // Takes an input from the user, divides it by 7.
            // =========================================================================
            Console.Write("Enter a number to divide by 7 (to find remainder): ");
            string input5 = Console.ReadLine();
            // Convert string input to a long integer.
            long number5 = Convert.ToInt64(input5);
            // Calculate remainder using modulus operator %
            long remainder = number5 % 7;
            Console.WriteLine($"Remainder of {number5} divided by 7 is: {remainder}\n");

            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}