class Swimming : Activity {
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length){
        setLaps(laps);
    }

    public void setLaps(int laps){
        _laps = laps;
    }

    public int getLaps(){
        return _laps;
    }

    public override double calDistance()
    {
        return getLaps() * 50 / 1000 * 0.62;
    }

    public override double calPace()
    {
        return getLength() / calDistance();
    }
    public override double calSpeed()
    {
        return 60 / calPace();
    }



    public override string getSummary()
    {
        return $"{getDate()} Swimming ({getLength()} mins) - Distance {Math.Round(calDistance(), 1).ToString("F1")} miles, Speed {Math.Round(calSpeed(), 1).ToString("F1")} mph, Pace: {Math.Round(calPace(), 1).ToString("F1")} min per mile";
    }

}