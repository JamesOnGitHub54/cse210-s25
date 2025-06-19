using System;

class Program
{
    static void Main(string[] args)
    {
        /// Set user number and give program instructions.
        int user_number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        /// Continue to enter numbers until 0 is typed.
        while (user_number != 0)
        {
            Console.WriteLine("Enter number: ");
            user_number = int.Parse(Console.ReadLine());
        }
    }
}