class Cycling : Activity{
    private double _speed;


    public Cycling(string date, int length, double speed) : base(date, length){
        setSpeed(speed);
    }
    public double getSpeed(){
        return _speed;
    }
    public void setSpeed(double speed){
        _speed = speed;
    }


    public override double calDistance()
    {
        return (getSpeed() * getLength()) / 60;
    }

    public override double calPace()
    {
        return 60 / getSpeed();
    }

    public override string getSummary()
    {
        return $"{getDate()} Cycling ({getLength()} mins) - Distance {Math.Round(calDistance(), 1).ToString("F1")} miles, Speed {Math.Round(getSpeed(), 1).ToString("F1")} mph, Pace: {Math.Round(calPace(), 1).ToString("F1")} min per mile";
    }
}