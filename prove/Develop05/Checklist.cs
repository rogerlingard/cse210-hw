using System.ComponentModel;


class Checklist : Goals {

    private int _bonusPoints;
    private int _amountOfTimesDone;
    private int _howMuchItNeedsToBeDone;

    // public Checklist(string name, string description, int points, bool complete, int bonusPoints, int amountofTimesDone, int howMuchItNeedsToBeDone) : base(name, description, points, complete) {}

    public void setBonusPoints(int bonusPoints){
        _bonusPoints = bonusPoints;
    }


    public int getBonusPoints(){
        return _bonusPoints;
    }

    public void setHowMuchItNeedsToBeDone(int howMuchItNeedsToBeDone){
        _howMuchItNeedsToBeDone = howMuchItNeedsToBeDone;
    }

    public int getHowMuchItNeedsToBeDone(){
        return _howMuchItNeedsToBeDone;
    }

    public void setAmountOfTimesDone(int amountofTimesDone){
        _amountOfTimesDone = amountofTimesDone;
    }

    public int getAmountOfTimesDone(){
        return _amountOfTimesDone;
    }

    public override void askQuestion()
    {
        base.askQuestion();
        Console.Write("How many times does this goal need to be accomplished for a bonus: ");
        setHowMuchItNeedsToBeDone(int.Parse(Console.ReadLine()));
        Console.Write("What is the bonus for accomplishing it that many times? ");
        setBonusPoints(int.Parse(Console.ReadLine()));
    }
    public override void displayGoals()
    {
        if(getCompleted()){
            Console.WriteLine($"[X] {getGoalName()} ({getDescription()}) -- Currently complete: {getAmountOfTimesDone()} / {getHowMuchItNeedsToBeDone()}");
        }
        else{
            Console.WriteLine($"[ ] {getGoalName()} ({getDescription()}) -- Currently complete: {getAmountOfTimesDone()} / {getHowMuchItNeedsToBeDone()}");
        }
    }


    public override string writeGoal()
    {
    
        string goalCondenseName = ($"ChecklistGoal:{getGoalName()},{getDescription()},{getPoints()},{getBonusPoints()},{getHowMuchItNeedsToBeDone()},{getAmountOfTimesDone()}");
        return goalCondenseName;
        
    }
}