using System;
using System.Collections.Generic;

public class Resume
{
    // Keep track of the person's name
    // and a list of their jobs.
    public string _name = "";
    public List<Job> _jobList = new List<Job>();

    // Displays the resume, which shows the
    // name first, followed by displaying
    // each one of the jobs.
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobList)
        {
            job.DisplayJobInfo();
        }
    }
}
