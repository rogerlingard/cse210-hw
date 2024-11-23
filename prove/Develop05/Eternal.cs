using System.IO;
class Eternal : Goals {

    // public Eternal(string name, string description, int points, bool complete) : base (name, description, points, complete) {}
        public override void displayGoals()
    {
        Console.WriteLine($"[ ] {getGoalName()} ({getDescription()}) ");
    }

    public bool getComplete()
    {
        return false; 
    }

    public override string writeGoal()
    {           
        string goalCondenseName = ($"EternalGoal:{getGoalName()},{getDescription()},{getPoints()}");
        return goalCondenseName;
    }


}