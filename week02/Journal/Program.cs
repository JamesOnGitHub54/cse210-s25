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
            if (userSelection == 1)
            {

            }

            // 2. Display
            else if (userSelection == 2)
            {

            }

            // 3. Load
            else if (userSelection == 3)
            {

            }

            // 4. Save
            else if (userSelection == 4)
            {

            }
            else if (userSelection !=5)
            Console.WriteLine("Invalid selection");

        }
        
    }
}