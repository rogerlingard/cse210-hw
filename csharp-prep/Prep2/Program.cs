using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade did you get? ");
        String grade = Console.ReadLine();
        int grade_int = int.Parse(grade);

        String letter = "";
        if(grade_int >= 90)
        {
            letter = "A";
        }
        else if(grade_int < 90 && grade_int>= 80)
        {
            letter = "B";
        }
        else if(grade_int < 80 && grade_int>= 70)
        {
            letter = "C";
        }
        else if(grade_int < 70 && grade_int>= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Youre Grade is: {letter} ");

        if(grade_int >= 70)
        {
            Console.WriteLine($"\nCongrats you did it! Good job, keep passing");
        }
        else
        {
            Console.WriteLine($"\nYou can do better next time, You got it and just try again. You know half the content at least.");
        }
    }
}