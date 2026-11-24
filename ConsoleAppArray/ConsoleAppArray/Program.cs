using System;
using System.Collections.Generic; // Required to use List<T>

namespace ConsoleAppArray{
    class Program{
        static void Main(string[] args){
            // Create an Array of strings
            // string[] colorsArray = new string[10];
            // string[] colorsArray = new string[] { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Pink", "Brown" };
            string[] colorArray = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Pink", "Brown" };

            // Prompt the user to select an index for the string array
            Console.WriteLine("Select a number between 0 and 9 to view a color:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            // Loop until the user enters a valid index within the array bounds
            while (!validString){
                try{
                    // Display the string at the chosen index
                    Console.WriteLine("Your favorite color is " + colorArray[stringSelect] + ".");
                    validString = true; // Exit the loop once a valid selection is made
                }
                // Display a message if the user selects an index that doesn't exist
                catch{
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9:");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Blank line for cleaner console spacing
            Console.WriteLine();

            // 2. Create an  Array of integers
            int[] numberArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            // Prompt the user to select an index for the integer array
            Console.WriteLine("Select a number between 0 and 9 to view an integer:");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            // Loop until the user enters a valid index within the integer array bounds
            while (!validInt){
                try{
                    // Display the integer at the chosen index
                    Console.WriteLine("Your chosen number is " + numberArray[intSelect] + ".");
                    validInt = true; // Exit the loop once a valid selection is made
                }
                // Display a message if the user selects an index that doesn't exist
                catch{
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9:");
                    intSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Blank line for cleaner console spacing
            Console.WriteLine();

            // Create a list of strings
            List<string> occupationList = new List<string>(){
                "Software Developer",
                "Data Analyst",
                "Network Engineer",
                "Cybersecurity Specialist",
                "Systems Administrator",
                "UX Designer",
                "Database Administrator",
                "Cloud Architect",
                "DevOps Engineer",
                "IT Support Specialist"
            };

            // Prompt the user to select an index for the list of strings
            Console.WriteLine("Select another number between 0 and 9 to view an occupation:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            // Loop until the user enters a valid index within the list bounds
            while (!validList){
                try{
                    // Display the string content at the chosen list index
                    Console.WriteLine("Your chosen occupation is " + occupationList[listSelect] + ".");
                    validList = true; // Exit the loop once a valid selection is made
                }
                // Display a message if the user selects an index that doesn't exist
                catch{
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9:");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Keep the console window open until the user presses Enter
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}