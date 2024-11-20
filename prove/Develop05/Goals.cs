using System.ComponentModel.DataAnnotations.Schema;

public  abstract class Goals{
    private string _name;

    private string _description;
    private int _points;
    private bool _completed;

    public Goals() {}
    // public Goals(string goalName, string goalDescription, int points, bool complete){  

    //     setGoalName(goalName);
    //     setDescription(goalDescription);
    //     setPoints(points);
    //     setComplete(complete);
    // }
    public string getGoalName(){
        return _name;
    }
    public void setGoalName(string name){
        _name = name;                
    }

    public string getDescription(){
        return _description;
    }
    public void setDescription(string description){
        _description = description;
    }

    public int getPoints(){
        return _points;
    }
    public void setPoints(int points){
        _points = points;
    }

    public bool getCompleted(){
        return _completed;
    }
    public void setComplete(bool complete){
        _completed = complete;
    }

    public virtual void displayGoals(){
        Console.WriteLine("The goals are:");
        
    }

    public virtual void askQuestion(){
        Console.WriteLine("What is the name of your goal? ");
        setGoalName(Console.ReadLine());
        Console.WriteLine("What is a short descrption of it? ");
        setDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associted with this goal? ");
        setPoints(int.Parse(Console.ReadLine()));
        setComplete(false);
        Console.WriteLine();
        Console.WriteLine($"Points: {getPoints()}");
    }


}