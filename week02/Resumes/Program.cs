using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Engineer";

        Job job2 = new Job();
        job2._company = "Microsoft";

        Console.WriteLine(job1._jobTitle);
        Console.WriteLine(job2._company);


    }
}