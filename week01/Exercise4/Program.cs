using System;

class Program
{
    static void Main(string[] args)
    {
        /// Set user number and give program instructions.
        int user_number = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        /// Continue to enter numbers until 0 is typed.
        while (user_number != 0)
        {
            Console.Write("Enter number: ");
            user_number = int.Parse(Console.ReadLine());
            if (user_number != 0)
            {
                numbers.Add(user_number);
            }
        }

        // Finding the sum of all numbers.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        // Finding the average of all numbers.
        float count_of_numbers = numbers.Count;
        float average = sum / count_of_numbers;

        // Finding the largest number of all numbers.

        // Display all results.
        Console.WriteLine($"Sum is: {sum}/Average is: {average}");
    }
}