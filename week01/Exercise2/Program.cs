using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade_percent = int.Parse(Console.ReadLine());
        string letter_grade;

        if (grade_percent >= 90)
        {
            letter_grade = "A";
        }
        else if (grade_percent >= 80)
        {
            letter_grade = "B";
        }
        else if (grade_percent >= 70)
        {
            letter_grade = "C";
        }
        else if (grade_percent >= 60)
        {
            letter_grade = "D";
        }
        else letter_grade = "F";

        Console.WriteLine($"You have earned the letter grade: {letter_grade}");

    }
}