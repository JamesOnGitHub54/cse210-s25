using System;

class Program
{
    static void Main(string[] args)
    {
        // Establish replay as yes. Program will end when user does not enter "yes".
        string replay = "yes";
        while (replay == "yes")
        {
            // User creates the magic number
            // Console.Write("What is the magic number?: ");
            // int magic_number = int.Parse(Console.ReadLine());

            // Magic number is randomly generated.
            Random randomGenerator = new Random();
            int magic_number = randomGenerator.Next(1, 101);

            // +1 allows to establish int guess while not matching magic number at startup.
            int guess = magic_number + 1;
            int attempt = 0;

            // Loop into guessing until magic number is found. Hints are given for each guess.
            while (guess != magic_number)
            {
                attempt = attempt + 1;
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
                else Console.WriteLine($"You guessed it! Number of attempts: {attempt}");
            }

            // User may play again if yes is entered. New magic number is generated and attempts reset.
            Console.Write("Would you like to play again?: ");
            replay = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing!");
    }
}