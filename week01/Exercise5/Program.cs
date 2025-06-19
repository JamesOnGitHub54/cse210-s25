using System;

class Program
{
    static void Main(string[] args)
    {
        // Main function progresses the program.
        DisplayWelcome();
        string user_name = PromptUserName();
        int favorite_number = PromptUserNumber();
        int square = SquareNumber(favorite_number);
        DisplayResult(user_name, square);
    }

    static void DisplayWelcome()
    {
        // Welcome message.
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        // Get user's name.
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
    }

    static int PromptUserNumber()
    {
        // Get user's number.
        Console.Write("Please enter your favorite number: ");
        int favorite_number = int.Parse(Console.ReadLine());
        return favorite_number;
    }

    static int SquareNumber(int favorite_number)
    {
        /// Get the square of user's number.
        int square = favorite_number * favorite_number;
        return square;
    }

    static void DisplayResult(string user_name, int square)
    {
        // Display results.
        Console.WriteLine($"{user_name}, the square of your number is {square}");
    }
}