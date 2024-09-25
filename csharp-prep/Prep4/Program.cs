using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished ");
        bool stop_while = false;
        while (stop_while == false){
            Console.Write("Enter number: ");
            string num = Console.ReadLine();
            int number = int.Parse(num);

            if (number == 0)
            {
                stop_while = true;
            }
            else{
                numbers.Add(number);
            }



        }
        int num_total = 0;
        int highest_num = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            num_total += numbers[i];

            if (numbers[i] > highest_num)
            {
                highest_num = numbers[i];
            }
            
        }
        Console.WriteLine($"The sum is: {num_total}");

        double num_average = 0;
        num_average = (double)num_total / numbers.Count;
        Console.WriteLine($"The average is: {num_average}");

        Console.WriteLine($"The largest number is: {highest_num}");

    }
}