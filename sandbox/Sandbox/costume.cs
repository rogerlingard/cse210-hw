class Costume{
    //attrubytes (member variables)
    public string headWare;

    public string gloves;

    public string shoes;

    public string upperGarment;

    public string lowerGarment;

    public string accessory;


    //behaviors (member functions, or *methods*)
    public void ShowWardrobe()
    {
        string result = "";
        result += "Head grear: " + headWare;
        result += "\nHand gear: " + gloves;
        result += "\nFoot grear: " + shoes;
        result += "\nTorso covering: " + upperGarment;
        result += "\nLeg grear: " + headWare;
        result += "\nAccesory: " + accessory;
        Console.WriteLine(result + "\n");
    }
}