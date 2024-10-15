class Bin {
    //attributes

    private string _denomination;

    private int _amount;

    private float _value;

    //methods
    
    public Bin(string _denomination, int amount, value) {
        _denomination = denomination;
        _amount = amount;
        _value = value;
    }


    public void ModifyAmount(int amount)
    {
        _amount += amount;
    }
    
    public float TotalValue()
    {
        return _amount * _value;
    }


}