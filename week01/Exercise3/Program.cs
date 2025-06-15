using System;

class Program
{
    static void Main(string[] args)
    {
        // User creates the magic number
        // Console.Write("What is the magic number?: ");
        // int magic_number = int.Parse(Console.ReadLine());

        // Magic number is randomly generated.
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);

        // +1 allows to establish int guess while not matching magic number at startup.
        int guess = magic_number + 1;

        // Loop into guessing until magic number is found. Hints are given for each guess.
        while (guess != magic_number)
        {
            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());
            if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else Console.WriteLine("You guessed it!");


        }
    }
}