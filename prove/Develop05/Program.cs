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

            Console.Write("Select a choice from the menu: ");

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
                    Console.WriteLine();
                    Console.WriteLine($"You have {goalList.getTotalPoint()} points.");
                    Console.WriteLine();
                }
                else if(goal_choice == 2){
                    Eternal eternalGoal = new();
                    eternalGoal.askQuestion();
                    goalList.addGoal(eternalGoal);
                    Console.WriteLine();
                    Console.WriteLine($"You have {goalList.getTotalPoint()} points.");
                    Console.WriteLine();
                }
                else if(goal_choice == 3)
                {
                    Checklist checklistGoal = new();
                    checklistGoal.askQuestion();
                    goalList.addGoal(checklistGoal);
                    Console.WriteLine();
                    Console.WriteLine($"You have {goalList.getTotalPoint()} points.");
                    Console.WriteLine();
                }
                else{
                    Console.WriteLine("Please input a valid number");
                }
            }
            else if (choice == 2){
                Console.WriteLine("The goals are:");
                goalList.displayGoals();
                Console.WriteLine();
                Console.WriteLine($"You have {goalList.getTotalPoint()} points.");
                Console.WriteLine();
            }
            else if (choice == 3){
                goalList.goalWrite();
            }
            else if (choice == 4){
                goalList.goalRead();
            }
            else if(choice == 5){
                goalList.completeGoal();
            }
            else if (choice == 6){
                break;
            }
        }
    }
}