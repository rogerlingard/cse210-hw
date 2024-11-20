class Eternal : Goals {

    public Eternal() {}
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