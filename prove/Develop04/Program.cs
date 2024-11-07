using System;

class Program
{
    static void Main(string[] args)
    {
    
         while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            int choice = int.Parse(Console.ReadLine());

            

            if(choice == 1){
                BreathingActivity breathingActivity = new();
                breathingActivity.BreathingExersise();
            }
            else if (choice == 4) {
                break;

            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
        
    }
}