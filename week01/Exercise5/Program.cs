using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        //call the functions

        DisplayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResults(name, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Enter your full name:");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);

        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is: {square}");

    }
}