class Vice : Goals{

    public override void displayGoals()
    {
        Console.WriteLine($"[ ] {getGoalName()} ({getDescription()}) ");
    }

    public override void askQuestion()
    {
        Console.Write("What is the name of your goal? ");
        setGoalName(Console.ReadLine());
        Console.Write("What is a short descrption of it? ");
        setDescription(Console.ReadLine());
        Console.Write("What is the amount of points this vice will subtract (it will set it as a negative)? ");
        setPoints(-Math.Abs(int.Parse(Console.ReadLine())));
        setComplete(false);
    }
    public override string writeGoal()
    {           
        string goalCondenseName = ($"ViceGoal:{getGoalName()},{getDescription()},{getPoints()}");
        return goalCondenseName;
    }

}