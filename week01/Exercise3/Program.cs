using System;

class Program
{
    static void Main(string[] args)
    {

        /*Console.Write("Enter the magic number: ");
        string number = Console.ReadLine();
        int hiddenNumber = int.Parse(number);
        */

        Console.Write("Guess the magic number: ");
        string guessed = Console.ReadLine();
        int myGuess = int.Parse(guessed);

        Random secretNumber = new Random();
        int secret = secretNumber.Next(1, 100);


        while (myGuess != secret)
        {
            if (myGuess > secret)
            {
                Console.WriteLine("Lower");
            }
            else if (myGuess < secret)
            {
                Console.WriteLine("Higher");
            }

            Console.Write("New guess: ");
            guessed = Console.ReadLine();
            myGuess = int.Parse(guessed);
        }

        Console.WriteLine("Congradulations. You guessed it");
    }
}