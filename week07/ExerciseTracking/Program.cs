using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>();

        Running run = new("running", 10, 45);
        StationaryBycicle ride = new("cycling", 24, 45);
        SwimmingPool swam = new("long Swimming", 4.5, 60);

        activities.Add(run);
        activities.Add(ride);
        activities.Add(swam);

        foreach (Activity line in activities)
        {
            Console.WriteLine(line.GetSumary());
        }
    }
}