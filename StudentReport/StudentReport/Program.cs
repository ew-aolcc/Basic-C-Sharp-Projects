using System;

namespace StudentDailyReport
{
    class Program{
        static void Main(string[] args){
        
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine(); // Blank line for better readability

            
            Console.Write("What is your name? ");
            string studentName = Console.ReadLine();

           
            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine();

          
            Console.Write("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

           
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            
            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string positiveExperiences = Console.ReadLine();

           
            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string feedback = Console.ReadLine();

            
            Console.Write("How many hours did you study today? ");
            float studyHours = float.Parse(Console.ReadLine());

            Console.WriteLine(); // Blank line before closing message

            
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}