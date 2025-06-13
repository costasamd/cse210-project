using System.Collections.Specialized;
using System.IO;
class Reflecting : Activities
{
    private List<string> _prompt;
    private List<string> _questions;

    //Constructor
    public Reflecting(string name, string description, int duration) : base(name, description, duration)
    {
        _prompt = new() {"Think about the hardest challenge you overcame", "think about something good you did", "Think about a scripture you read",
        "Remember a moment of joy", "think about life's lesson you learned", "think about the creation of the world"};

        _questions = new()
        {
            "Why it was meaningful to you?", "How did you felt whe  you completed?", "What was the hardest part of this experience?", "How can you use this experience in the future?",
            "how could you pass knowledge to others through your experience?", "If you need to do it again, what would you do different?", "What can you do to improve yourself after this exprience?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(getDescription);

        double seconds = getDuration;

        Thread.Sleep(3000);

        DateTime starTime = DateTime.Now;
        DateTime futuretime = starTime.AddSeconds(seconds);


        DisplayPrompt();
        Shownimation();
        Console.WriteLine("Get ready..");
        Thread.Sleep(1000);



        while (DateTime.Now < futuretime)
        {

            DisplayQuestion();
            Thread.Sleep(5000);
        }
        DisplayEndMessage();
        SaveActivity();

    }

    public string GetRandomPrompt()
    {
        string newPrompt = "";

        Random prompt = new();

        int index = prompt.Next(_prompt.Count());
        newPrompt = _prompt[index];


        return newPrompt;
    }

    public string GetRandomQuestion()
    {
        string question = "";

        Random quest = new();
        int index = quest.Next(_questions.Count());
        question = _questions[index];

        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}