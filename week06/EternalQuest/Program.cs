using System;
using System.IO;

//my creative part, once a goal is completed it is removed from the list and from the log file.
//I am using a CSV file to save and to load from
//Separated file for player track his points and number of goals completed

class Program
{
    static void Main(string[] args)
    {
        GoalManager test = new();

        test.Start();

    }
}