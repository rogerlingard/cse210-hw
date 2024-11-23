using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.IO;

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

    public  virtual bool getCompleted(){
        return _completed;
    }
    public virtual void setComplete(bool complete){
        _completed = complete;
    }

    public virtual void displayGoals(){       
    }

    public virtual void askQuestion(){
        Console.Write("What is the name of your goal? ");
        setGoalName(Console.ReadLine());
        Console.Write("What is a short descrption of it? ");
        setDescription(Console.ReadLine());
        Console.Write("What is the amount of points associted with this goal? ");
        setPoints(int.Parse(Console.ReadLine()));
        setComplete(false);

    }

    public virtual string writeGoal(){
        return "";

    }

}