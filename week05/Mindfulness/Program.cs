using System;
using System.IO;

//for my crative part, my program save the activity name, duration and date when was completed in a txt file
//also I add the function to see the file.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Breathing Activity\n 2. Reflecting Activity\n 3. Listing Activity\n 4. Check my Activity\n 5. Quit");
        Console.WriteLine("Choose from the menu the activity you to do");
        string userChoice = Console.ReadLine();
        int userChosen = int.Parse(userChoice);

        //breathing activity
        if (userChosen == 1)
        {
            string name = "Breathing Activity";
            string description = "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
            Console.WriteLine("How long in seconds you would like to do the activity?");
            string time = Console.ReadLine();
            int timer = int.Parse(time);

            Breathing newActivity = new(name, description, timer);

            newActivity.Run();

        }

        //Meditation activity
        else if (userChosen == 2)
        {
            string name = "Reflection Activity";
            string description = "Reflection (Meditation) will help you to focus on specific times of your life and get a deep understand and knowledge about yourself. This will help you to leave behind the moment and center all your attention in one specific experience, this will promote a better understanding and multiple prespective above one specific moment of your life ";
            Console.WriteLine("How long in seconds you would like to do the activity?");
            string time = Console.ReadLine();
            int timer = int.Parse(time);

            Reflecting newActivity = new(name, description, timer);

            newActivity.Run();
        }

        //Listing activity
        else if (userChosen == 3)
        {
            string name = "Listing Activity";
            string description = "The Listing Activity will focus on the good things happening in your life by having you list as many words as you can in a certain area.";
            Console.WriteLine("How long in seconds you would like to do the activity?");
            string time = Console.ReadLine();
            int timer = int.Parse(time);

            Listing newActivity = new(name, description, timer);

            newActivity.Run();

        }

        else if (userChosen == 4)
        {
            Activities load = new Activities();

            load.LoadLogFile();

        }

        else if (userChosen == 5)
        {
            Console.Write("Thank you for using our system");
        }

    }

}