class Checklist : Goals {

    private int _bonusPoints;
    private int _amountOfTimesDone;

    public void setBonusPoints(int bonusPoints){
        _bonusPoints = bonusPoints;
    }

    public int getBonusPoints(){
        return _bonusPoints;
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
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus: ");
        setAmountOfTimesDone(int.Parse(Console.ReadLine()));
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");

    }
}