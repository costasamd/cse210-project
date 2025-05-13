using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2024;
        job1._endYear = 2030;

        Job job2 = new();
        job2._jobTitle = "Software Developer";
        job2._company = "Google";
        job2._startYear = 2022;
        job2._endYear = 2025;

        Resume resume1 = new();
        resume1._name = "Samuel D.C";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();



    }
}
