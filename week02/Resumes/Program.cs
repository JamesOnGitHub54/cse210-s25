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

        // Creating job 3
        Job job3 = new Job();
        job3._jobTitle = "Actor";
        job3._company = "Fox";
        job3._startYear = "2000";
        job3._endYear = "Present";

        // Creating a new resume with a set name. Moves specified jobs to resume.
        Resume resume1 = new Resume();
        resume1._name = "Bob Hill";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Creating resume 2
        Resume resume2 = new Resume();
        resume2._name = "Peter Smith";
        resume2._jobs.Add(job3);

        // Display results.
        resume1.Display();
        Console.WriteLine();
        resume2.Display();




    }
}