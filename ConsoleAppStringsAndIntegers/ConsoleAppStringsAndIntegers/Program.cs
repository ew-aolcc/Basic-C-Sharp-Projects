using System;
using System.Collections.Generic;

namespace ConsoleAppStringsAndIntegers {
    class Program {
        static void Main(string[] args) {
            // Create a list of integers
            List<int> intList = new List<int>() { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };

            // Flag to check if number is vaild
            bool isValid = false;

            // Loop while user input is not valid
            while (!isValid) {
                // Using a try/catch block to catch potential error.
                try {
                    Console.WriteLine("\nEnter a number to divide the above list by: ");
                    double numDivide = double.Parse(Console.ReadLine());

                    // If statement to check if the user entered 0
                    if (numDivide == 0) {
                        Console.WriteLine("Please enter a number other than 0.");
                    }
                    // Dividing each number in the list by the input
                    else {
                        foreach (int num in intList) {
                            double Divide = num / numDivide;
                            Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                        }

                        // Break the Loop
                        isValid = true;
                    }
                }
                // Catch block to display error message for string input
                catch (FormatException ex) {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Message to let the user know the program has exited the try/catch block
            Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution.");
            Console.ReadLine();
        }
    }
}