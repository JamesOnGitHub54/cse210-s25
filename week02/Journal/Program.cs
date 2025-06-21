using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = -1;
        Console.WriteLine("Welcome to the Journal Program!");

        while (userSelection != 5)
        {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");

            Console.Write("What would you like to do? ");
            userSelection = int.Parse(Console.ReadLine());

            // 1. Write
            

            // 2. Display

            // 3. Load

            // 4. Save

            // 5. Quit

        }
        
    }
}