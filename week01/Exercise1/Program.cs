using System;

class Program
{
    static void Main(string[] args)
    {
        // Get user's full name, separated by first and last name.
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        // Display user's full name in as James Bond would.
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}