class Simple : Goals{

    public Simple() {}
    // public Simple(string goalName, string goalDescription, int points, bool complete) : base(goalName, goalDescription, points, complete){

    // }

    public override void displayGoals()
    {
        if(getCompleted()){
            Console.WriteLine($"1. [X] {getGoalName()} ({getDescription()}) ");
        }
        else{
            Console.WriteLine($"1. [ ] {getGoalName()} ({getDescription()}) ");
        }
    }

}