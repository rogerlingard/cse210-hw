class Running : Activity{
    private double _distance;

    public Running (string date, int length, double distance) : base(date, length){
        setDistance(distance);
    }

    public void setDistance(double distance){
        _distance = distance;
    }
    public double getDistance(){
        return _distance;
    }

    public override double calSpeed()
    {
        return (getDistance() / getLength()) * 60;
    }

    public override double calPace()
    {
        return getLength() / getDistance();
    }

    public override string getSummary()
    {
        return $"{getDate()} Running ({getLength()} mins) - Distance {Math.Round(getDistance(), 1).ToString("F1")} miles, Speed {Math.Round(calSpeed(), 1).ToString("F1")} mph, Pace: {Math.Round(calPace(), 1).ToString("F1")} min per mile";
    }


}