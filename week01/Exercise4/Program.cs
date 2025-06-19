using System;

class Program
{
    static void Main(string[] args)
    {
        /// Set user number and list. Give program instructions.
        int user_number = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        /// Add numbers to list until 0 is typed.
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
        int largest_number = user_number;
        foreach (int number in numbers)
        {
            if (number > largest_number)
            {
                largest_number = number;
            }
        }

        // Display all results.
        Console.WriteLine($"The Sum is: {sum}\nThe average is: {average}\nThe largest number is: {largest_number}");
    }
}