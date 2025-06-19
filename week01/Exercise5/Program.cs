using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message.
        Console.WriteLine("Welcome to the program!");

        // Get user's name.
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();

        // Get user number.
        Console.Write("Please enter your favorite number: ");
        int favorite_number = int.Parse(Console.ReadLine());

        // Get square of number.
        int square = favorite_number * favorite_number;

        // Display results.
        Console.WriteLine($"{user_name}, the square of your number is {square}");


    }
}