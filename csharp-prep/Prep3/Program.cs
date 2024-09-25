using System;

class Program
{
    static void Main(string[] args)
    {
       
        Random randomGenerator = new Random();
        int guess_num = randomGenerator.Next(1, 101);

        int guesses = 0;

        bool answer = false;
        while(answer == false)

        {
            Console.Write("What is your guess? ");
            String num = Console.ReadLine();
            int number = int.Parse(num);
            guesses++;

            if(number > guess_num)
            {
                Console.WriteLine("Guess lower");
            }
            else if(number < guess_num)
            {
                Console.WriteLine("Guess higher");
            }
            else
            {
                Console.WriteLine("You got it!");
                Console.WriteLine($"It took you {guesses}");
                answer = true;
            }
        }

    }
}