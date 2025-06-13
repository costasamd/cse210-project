using System.Diagnostics;
using System.IO;


class Breathing : Activities
{
    //Constructor

    public Breathing(string name, string description, int duration) : base(name, description, duration)
    {   
        
    }


    //method
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(getDescription);

        double seconds = getDuration;

        Thread.Sleep(3000);


        ShowCountDown();

        DateTime starTime = DateTime.Now;
        DateTime futuretime = starTime.AddSeconds(seconds);

        while (DateTime.Now < futuretime)
        {
            Console.WriteLine("Breath in...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("Hold your breath...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("Breath out...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("Hold breath...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        }

        DisplayEndMessage();
        SaveActivity();
        
    }
}