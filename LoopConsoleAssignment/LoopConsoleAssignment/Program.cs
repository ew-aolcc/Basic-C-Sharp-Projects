using System;

namespace LoopConsoleAssignment{
    class Program{
        static void Main(string[] args){
            // Init count to 0
            int count = 0;

            // Do Something then Loop while count < 5
            do{
                Console.WriteLine("Inside the loop");
                
                // Increment by 1
                count++;
            }while (count < 5);

            // Init counting to 0
            int counting = 0;

            // Loop while count < 3
            while (counting < 3){
                Console.WriteLine("Counting numbers");

                // Increment by 1
                counting++;
            }

            Console.ReadLine();
        }
    }
}