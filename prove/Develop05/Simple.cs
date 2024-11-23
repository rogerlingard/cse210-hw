using System.IO;
class Simple : Goals{

    public Simple() {}
    // public Simple(string goalName, string goalDescription, int points, bool complete) : base(goalName, goalDescription, points, complete){

    // }

    public override void displayGoals()
    {
        if(getCompleted()){
            Console.WriteLine($"[X] {getGoalName()} ({getDescription()}) ");
        }
        else {
            Console.WriteLine($"[ ] {getGoalName()} ({getDescription()}) ");
        }
    }

    public override string writeGoal()
    {
            string goalCondenseName = $"SimpleGoal:{getGoalName()},{getDescription()},{getPoints()},{getCompleted()}";
            return goalCondenseName;        
    }

}