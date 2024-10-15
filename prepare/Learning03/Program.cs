using System;

class Program
{
    static void Main(string[] args)
    {
        //learning fun fraction things, just experimenting.
    //    Fraction no_prams = new();
    //    Fraction one_prams = new(6);
    //    Fraction two_prams = new(6, 7);

    //    string no_prams_string = no_prams.GetFractionString();
    //    Console.WriteLine(no_prams_string);
    //    Console.WriteLine(no_prams.GetDecimalValue());
       
    //    Console.WriteLine(one_prams.GetFractionString());
    //    Console.WriteLine(one_prams.GetDecimalValue());
    //    Console.WriteLine(two_prams.GetFractionString());
    //    Console.WriteLine(two_prams.GetDecimalValue());
        Fraction frac = new();
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());

        frac.SetTop(5);
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());

        frac.SetTop(3);
        frac.SetBottom(4);
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());

        Fraction new_frac = new(1, 3);
        Console.WriteLine(new_frac.GetFractionString());
        Console.WriteLine(new_frac.GetDecimalValue());


    }
}