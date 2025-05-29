using System;
using System.Collections.Generic;
using System.Linq;


//As creative I add the function of quit to a keyboard botton as well


class Program
{
    static void Main(string[] args)
    {

       
        Reference reference = new("Nephi", 3, 7);
        string text = "And it came to pass that I, Nephi, said to my father: I will go and do the things which the things which the Lord has commanded";
        Random numberToHide = new();

        Scripture memo = new(reference, text);


        while (!memo.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(memo.GetDisplayText());

            Console.WriteLine("Press Enter to continue or press ESC to quit");

            var key = Console.ReadKey(true);

            //make words desapear
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                memo.HideRandomNumber(numberToHide.Next(1, 5));
                Console.WriteLine(memo.GetDisplayText());
            }

            //finish the program

            else if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                break;
            }

            memo.HideRandomNumber(numberToHide.Next(1, 5));
        }

        Console.Clear();
        Console.WriteLine(memo.GetDisplayText());


    }
}