using System.Collections.Generic;
using System.IO;

//Program saves entries to a CSV file automatically, it also load from the file automatically.
//I use the datetime lib to get the date of user entry
//
 
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Welcome to your journal.\nWhat you would like to do?");
        Console.WriteLine("Using index, choose one of the following options.\n0. Close the Journal\n1. Read past Entries\n2. Add a new Entry");
        string choice = Console.ReadLine();
        int userChoice = int.Parse(choice);

        while (userChoice != -1)
        {
            if (userChoice == 1)
            {
                Journal jornalPages = new Journal();

                jornalPages.DisplayEntries();

                //restart
                Console.WriteLine("Using index, choose one of the following options.\n0. Close the Journal\n1. Read past Entries\n2. Add a new Entry");
                choice = Console.ReadLine();
                userChoice = int.Parse(choice);


            }
            else if (userChoice == 2)
            {
                //prepare the obj and call them to let user add new entry and save it in file
                Journal entry = new Journal();
                PromptGenerator prompt = new PromptGenerator();
                Entry userInput = new Entry();

                //iterate through prompt to get the string out of the list


                userInput._date = DateTime.Now.ToString("MM/dd/yyyy");
                userInput._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(userInput._promptText);
                Console.WriteLine("Write here:");
                userInput._entryText = Console.ReadLine();

                userInput.DisplayEntry();

                entry.AddEntry(userInput);

                //restart
                Console.WriteLine("Using index, choose one of the following options.\n0. Close the Journal\n1. Read past Entries\n2. Add a new Entry");
                choice = Console.ReadLine();
                userChoice = int.Parse(choice);


            }
            else if (userChoice == 0)
            {
                Console.WriteLine("Closing Journal...");
                break;
            }
            else
            {
                Console.Write("Invalid Response. Try again.");
                Console.WriteLine("Using index, choose one of the following options.\n0. Close the Journal\n1. Read past Entries\n2. Add a new Entry");
                choice = Console.ReadLine();
                userChoice = int.Parse(choice);
            }
        }
    }
}