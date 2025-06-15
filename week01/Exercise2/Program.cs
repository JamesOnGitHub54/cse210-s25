using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for grade percentage and set variables.
        Console.Write("What is your grade percentage? ");
        int grade_percent = int.Parse(Console.ReadLine());
        string letter;

        // Determine letter grade, including "+" and "-" symbols.
        if (grade_percent >= 93)
        {
            letter = "A";
        }
        else if (grade_percent >= 90)
        {
            letter = "A-";
        }
        else if (grade_percent >= 87)
        {
            letter = "B+";
        }
        else if (grade_percent >= 83)
        {
            letter = "B";
        }
        else if (grade_percent >= 80)
        {
            letter = "B-";
        }
        else if (grade_percent >= 77)
        {
            letter = "C+";
        }
        else if (grade_percent >= 73)
        {
            letter = "C";
        }
        else if (grade_percent >= 70)
        {
            letter = "C-";
        }
        else if (grade_percent >= 67)
        {
            letter = "D+";
        }
        else if (grade_percent >= 63)
        {
            letter = "D";
        }
        else if (grade_percent >= 60)
        {
            letter = "D-";
        }
        else letter = "F";

        // Determine if user has failed or passed the course and display the corresponding message.
        if (grade_percent >= 70)
        {
            Console.WriteLine($"Congratulations, you have passed the course! You have earned a letter grade of: {letter}.");
        }
        else Console.WriteLine($"Unfortunately, you have failed the course. You have earned a letter grade of: {letter}. You can do it, next time!");

    }
}