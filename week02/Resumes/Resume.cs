public class Resume()
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        // Format to present name and jobs.
        Console.WriteLine($"Name: {_name}\nJobs:");
        // Iterate through each job
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}