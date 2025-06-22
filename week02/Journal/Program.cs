using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = -1;
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal1 = new Journal();

        while (userSelection != 5)
        {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");

            Console.Write("What would you like to do? ");
            userSelection = int.Parse(Console.ReadLine());

            // 1. Write
            if (userSelection == 1)
            {
                Entry entry1 = new Entry();
                journal1.AddEntry(entry1);
                journal1.DisplayAll();


            }

            // 2. Display
            else if (userSelection == 2)
            {
                journal1.DisplayAll();
            }

            // 3. Load
            else if (userSelection == 3)
            {
                Console.Write("What is the name of the file?: ");
                string file_name = Console.ReadLine();
                journal1.LoadToFile(file_name);
            }

            // 4. Save
            else if (userSelection == 4)
            {
                Console.Write("What is the name of the file?: ");
                string file_name = Console.ReadLine();
                journal1.SaveToFile(file_name);

            }
            else if (userSelection != 5)
                Console.WriteLine("Invalid selection");

        }
        
    }
}