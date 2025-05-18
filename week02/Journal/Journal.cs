using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

        saveToFile(_entries);
    }



    public void saveToFile(List<Entry> _entries)
    {
        //Saving the entries to a csv file

        string filename = "entries.csv";

        //this comand line writes a file and once it finish it, it close the file.

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {

            foreach (Entry line in _entries)
            {
                outputFile.WriteLine($"{line._date}\",{line._promptText}\",{line._entryText}");
            }
        }
    }

    public List<string> loadFromFile()
    {
        List<string> entries = new List<string>();

        Console.WriteLine("Loading Journal...");

        string filename = "entries.csv";

        //read file and put it in an array of strings called Lines
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            
            //convertir the array in different arrays, then create the Entry obj again to transform the string back to Entry

            string[] parts = line.Split("\",");

            //parts[0] - date
            //parts[1] - prompt
            //parts[2] - text entry

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            entries.Add($"Date:{date}\nPrompt:{prompt}\nEntry:{entry}");
        }
        return entries;
    }

    public void DisplayEntries()
    {
        List<string> journalRead = loadFromFile();

        foreach (string line in journalRead)
        {
            Console.WriteLine(line);
        
        }

    }


}