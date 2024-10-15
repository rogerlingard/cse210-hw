class Program {

    static void Main(string[] args)
    {
        Bin myBin = new();
        myBin.ModifyAmount(6);
        Console.WriteLine(myBin.TotalValue());

    }

    
}