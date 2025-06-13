using System.Dynamic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System;
using System.IO;


class Activities
{
    private string _name;
    private string _description;
    private int _duration;

    private DateTime _timeRegister = new DateTime();

    //getter
    public string getDescription => _description;
    public int getDuration => _duration;

    //Constructor

    public Activities()
    {

    }

    public Activities(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //Methods

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well Done. You completed the {_name} for {_duration} seconds");
    }

    public void Shownimation()
    {
        Console.WriteLine("Get Ready...");
        Thread.Sleep(2000);
        for (int i = 0; i < 5; i++)
        {
            // string word = "Loading...";
            // Console.Write(word);
            // Thread.Sleep(1000);
            // Console.Write("\b\b\b\b\b\b\b\b\b\b\b           \b\b\b\b\b\b\b\b\b\b\b");
            // Thread.Sleep(1000);

            Console.Write("v");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("<");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("^");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(">");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown()
    {
        Console.WriteLine("Get Ready...");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    //Creative part, saving the activity to a log file
    public void SaveActivity()
    {
        //Create and save to a log txt

        Console.WriteLine("Saving to the file");

        string fileName = "activity.txt";

        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine($"Date: {DateTime.Now.ToString("dd/MM/yyyy - h:mm")} - Activity: {_name} - Duration(Sec): {_duration}");
        }
    }

    public void LoadLogFile()
    {
        string fileName = "activity.txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Thread.Sleep(1000);
            Shownimation();
            Console.Write(line);
        }
    }
}