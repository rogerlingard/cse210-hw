using System;

class Program
{
    static void Main(string[] args)
    {
        GoalList goalList = new();
        while(true){

            Console.WriteLine("Menu Option:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.WriteLine("Select a choice from the menu: ");

            int choice = int.Parse(Console.ReadLine());

            if(choice == 1){
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                int goal_choice = int.Parse(Console.ReadLine());

                if(goal_choice == 1){
                    Simple simpleGoal = new();
                    simpleGoal.askQuestion();
                    goalList.addGoal(simpleGoal);
                }
                else if(goal_choice == 2){
                    Eternal eternalGoal = new();
                    eternalGoal.askQuestion();
                    goalList.addGoal(eternalGoal);
                }
            }
        }
    }
}