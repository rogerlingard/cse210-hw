using System.Runtime.CompilerServices;

abstract class Activity {
    private string _date;
    private int _lengthOfActivity;

    public Activity(string date, int lengthOfActivity){
        setDate(date);
        setLength(lengthOfActivity);
    }

    public void setDate(string date){
        _date = date;
    }
    public string getDate(){
        return _date;
    }

    public void setLength(int length){
        _lengthOfActivity = length;
    }
    public int getLength(){
        return _lengthOfActivity;
    }

    public virtual string getSummary(){
        return $"{getDate()} Activity {getLength()} - Activity information";
    }

    public virtual double calDistance(){
        return 0;
    }
    
    public virtual double calSpeed(){
        return 0;
    }

    public virtual double calPace(){
        return 0;
    }
}