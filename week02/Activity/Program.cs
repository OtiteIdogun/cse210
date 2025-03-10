using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2000;
        job1._endYear = 2018;

        job1.DisplayJobInfo();

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Data Scientist";
        job2._startYear = 1999;
        job2._endYear = 2010;

        string company1 = job1._company;
        string company2 = job2._company;
        

        Console.WriteLine($"\n{company1} \n{company2}\n");
        

        Resume resume1 = new Resume();
        resume1._name = "Otite Idogun";
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);
        
        resume1.DisplayResume();
    }
}
