using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your username: ");
            string user_name = Console.ReadLine();
            return user_name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int user_number = int.Parse(Console.ReadLine());
            return user_number;
        }
        static int SquareNumber(int user_num)
        {
            int num_square = user_num * user_num;
            return num_square;
        }
        static void DisplayResult(string user_name, int num_square)
        {
            Console.WriteLine($"{user_name}, the square of your number is {num_square}");
        }
        DisplayWelcome();
        string user_name = PromptUserName();
        int fav_num = PromptUserNumber();
        int square = SquareNumber(fav_num);
        DisplayResult(user_name, square);

    }
}