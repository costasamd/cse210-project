using System.Collections.Generic;


public class PromptGenerator
{
    public List<string> _prompt = new List<string>()
    {
        "Write the good and bad and also the funny moments of your day", "Write how you helped someone and how you was helped by someone today",
        "Write a spiritual experience you had today", "Write a learning experience of this day", "Failing is part of the process. How did you fail today? and what will you do different next time?",
        "What was your Wow moment of the day?"
    };

    // public List<string> GetRandomPrompt()
    // {
    //     List<string> prompt = new List<string> { };

    //     Random str = new Random();

    //     int index = str.Next(_prompt.Count);

    //     prompt.Add(_prompt[index]);

    //     foreach (string prompted in prompt)
    //     {
    //         Console.WriteLine(prompted);
    //     }

    //     return prompt;

    // }

    public string GetRandomPrompt()
    {
        //create a random obj

        Random prompt = new Random();

        //using index to get a random prompt from the list

        int index = prompt.Next(_prompt.Count);

        //pass the random prompt for a new var
        // Console.WriteLine(_prompt[index]);
        // string prompted = Console.ReadLine();

        string prompted = _prompt[index];

        return prompted;

    }


}