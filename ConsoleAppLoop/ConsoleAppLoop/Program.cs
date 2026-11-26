using System;                     // Gives access to basic classes such as Console
using System.Collections.Generic; // Required to use List<T>
using System.Text;                // Required to use StringBuilder

namespace ConsoleAppLoop{
    class Program{
        static void Main(string[] args){
            // ==============================================================
            // PART 1
            // ==============================================================

            // A one-dimensional array of strings.
            string[] wordstart = {
                "Province: ",
                "City: ",
                "Phone: "
            };


            // Use a list to hold the user input, avoid static size.
            List<string> responses = new List<string>();

            // Ask the user to input some text and store each answer in the list.
            Console.WriteLine("Please enter your province:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter your city:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter your phone number:");
            responses.Add(Console.ReadLine());

            // A loop that iterates through each string in the array
            // and append the user's text input to the end of each string
            for (int i = 0; i < wordstart.Length; i++){
                wordstart[i] += responses[i];
            }

            // A loop that print each string in the array one at a time, each on its own line.
            Console.WriteLine("\nYour informaton:");
            for (int i = 0; i < wordstart.Length; i++){
                Console.WriteLine(wordstart[i]);
            }
            Console.ReadLine(); // Pause until the user presses Ente

            // ==============================================================
            // PART 2
            // ==============================================================

            // Create an infinite loop
            // Fix using a condition that breaks the loop
            // Could have also added a toggle value
            Console.WriteLine("Updating information:");
            int dots = 0;
            while (true){
                dots++;

                Console.Write(".");

                if(dots > 3) {
                    break;
                }
            }
            Console.WriteLine("\nInformation updated!");
            Console.ReadLine();

            // ==============================================================
            // PART 3
            // ==============================================================

            Console.WriteLine("Is that a ghost?!");
            // StringBuilder lets us add characters efficiently
            StringBuilder boo = new StringBuilder();
            // Start the word with "B"
            boo.Append("B");

            // Loop using the "<" operator: keep adding "o" while the length is LESS THAN 10.
            // Stops at exactly 10 characters ("B" + 9 "o"s).
            while (boo.Length < 10){
                boo.Append("o");
            }

            // Add an exclamation mark to the end
            boo.Append("!");
            // Print "Booooooooo!"
            Console.WriteLine(boo);
            // Pause until the user presses Enter
            Console.ReadLine();

            // A second StringBuilder for the next word
            StringBuilder ahh = new StringBuilder();
            // Start the word with "A"
            ahh.Append("A");

            // Loop using the "<=" operator: keep adding "h" while the length is LESS THAN OR EQUAL TO 10.
            // Runs one extra time compared to "<", so it stops at 11 characters ("A" + 10 "h"s).
            while (ahh.Length <= 10) {
                ahh.Append("h");
            }

            // Add an exclamation mark to the end
            ahh.Append("!");
            // Print "Ahhhhhhhhhh!"
            Console.WriteLine(ahh);
            // Pause until the user presses Enter
            Console.ReadLine();

            // ==============================================================
            // PART 4
            // ==============================================================

            // A list of strings where every item is unique (no team appears twice).
            List<string> teams = new List<string>() {
                "Bucks", "Raptors", "Celtics", "Heat", "Pacers", "76ers", "Nets", "Magic",
                "Wizards", "Hornets", "Bulls", "Knicks", "Pistons", "Hawks", "Cavaliers"
            };

            Console.WriteLine("NBA Eastern Conference Standings");
            // Ask the user for text to search for
            Console.WriteLine("Enter team name:");

            // Becomes true once a matching team is found
            bool isValid = false;
            // Index of the matching team (-1 means "not found yet")
            int index = -1;

            // Outer loop: keep asking until the user enters a team that is on the list.
            while (!isValid) {
                // Read the user's search text
                string teamRequest = Console.ReadLine();
                // Tracks the current position in the list
                int i2 = 0;

                // Inner loop: go through each team in the list looking for a match.
                foreach (string team in teams) {
                    // Check if the item match what the user typed
                    if (teamRequest == team) {
                        // Save the index of the matching item
                        index = i2;
                        // Mark that a match was found
                        isValid = true;
                        // Stop the loop as soon as the match is found
                        break;
                    }
                    // Move on to the next index
                    i2++;
                }

                // If no match was found, tell the user their input is not on the list.
                if (!isValid) {
                    Console.WriteLine("\"" + teamRequest + "\" is not on the list. Enter again:");
                }
            }

            // Display the index of the matching item, plus its standing (index + 1).
            Console.WriteLine("Processing... Index is: " + index + ". So...");
            Console.WriteLine("Standing is: " + (index + 1));
            Console.ReadLine(); // Pause until the user presses Enter

            // ==============================================================
            // PART 5
            // ==============================================================

            // A list of strings with identical items ("Reserved", "Vacant" and "Taken" all repeat).
            List<string> tables = new List<string>() { "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Reserved", "Taken" };

            Console.WriteLine("Welcome to Swell Taco!\nWe have a computerized check-in.\nIf you have a reservation type \"Reserved\".\nIf you are joining a party that is already here type \"Taken\".\nOtherwise type \"Vacant\".");
            // Ask the user for text to search for
            Console.WriteLine("Enter selection:");
            // Read the user's search text
            string selection = Console.ReadLine();
            // Becomes true if at least one match is found
            bool foundTable = false;

            // Loop through every item in the list and display the index of EVERY match.
            // There is no "break" here, so the loop keeps going and finds multiple matches.
            for (int i3 = 0; i3 < tables.Count; i3++) {
                if (selection == tables[i3]) // Does this item match what the user typed?
                {
                    // Print the heading only once, right before the first match.
                    if (!foundTable) {
                        Console.WriteLine("The tables that match your selection are numbered:");
                    }
                    // Display the index of this matching item
                    Console.WriteLine(i3);
                    // Remember that at least one match was found
                    foundTable = true;
                }
            }

            // If the loop finished without any match, tell the user their input is not on the list.
            // (The user is not given another chance, as the instructions allow.)
            if (!foundTable) {
                Console.WriteLine("\"" + selection + "\" is not on the list.");
            }
            // Pause until the user presses Enter
            Console.ReadLine();

            // ==============================================================
            // PART 6
            // ==============================================================

            // A list of strings with identical items ("Bob" and "Mary" appear twice).
            List<string> names = new List<string>() { "Bob", "Jim", "Tiffany", "Bob", "Kat", "Mary", "Mary" };

            // A second list that records each name once it has been seen.
            List<string> alreadySeen = new List<string>();

            Console.WriteLine("Class Roster:");

            // Evaluate each item in the list one at a time.
            foreach (string name in names){
                // Has this name appeared earlier in the list?
                if (alreadySeen.Contains(name)) {
                    Console.WriteLine(name + " - this item is a duplicate");
                }
                else {
                    Console.WriteLine(name + " - this item is unique");
                    // Record the name so later copies are flagged as duplicates
                    alreadySeen.Add(name);
                }
            }
            // Pause until the user presses Enter before the program closes
            Console.ReadLine();
        }
    }
}