using System;
using System.IO;

class Listing : Activities
{
    private int _count;
    private List<string> _prompts;

    private List<string> userList = new List<string>();

    //constructor
    public Listing(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new()
        {
        "How did you show stregth this week?", "What can you do when you are afraid?", "Write some kind words for yourself", "Write Empowering words that you can repeat every morning", "How did you help someone?",
        "What is corauge", "What is the Christ attributes?", "How the scriptures helped you this week?"
        };
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(getDescription);

        double seconds = getDuration;

        Thread.Sleep(3000);

        DateTime starTime = DateTime.Now;
        DateTime futuretime = starTime.AddSeconds(seconds);

        GetRandomPrompt();
        Thread.Sleep(1500);

        while (DateTime.Now < futuretime)
        {

            GetFromUser();

        }
        DisplayEndMessage();
        Console.WriteLine($"You listed {_count} itens.");
        SaveActivity();

    }

    public void GetRandomPrompt()
    {
        Random number = new Random();
        int index = number.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);

    }

    public List<string> GetFromUser()
    {
        string newLine = "> ";
        Console.Write(newLine);
        string newWord = Console.ReadLine();
        userList.Add(newWord);
        _count = userList.Count;

        return userList;
    }

}