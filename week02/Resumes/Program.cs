using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating job 1.
        Job job1 = new Job();
        job1._jobTitle = "Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2017";
        job1._endYear = "2019";

        // Creating job 2.
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = "2020";
        job2._endYear = "2022";

        // Display jobs.
        job1.Display();
        job2.Display();




    }
}