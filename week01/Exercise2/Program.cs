using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string userGrade = Console.ReadLine();
        int userGradeNumber = int.Parse(userGrade);

        string letter;

        if (userGradeNumber >= 90)
        {
            //Console.WriteLine("Your grade is: A");
            letter = "A";
        }
        else if (userGradeNumber >= 80)
        {
            //Console.WriteLine("Your garde is: B");
            letter = "B";
        }
        else if (userGradeNumber >= 70)
        {
            //Console.WriteLine("Your grade is: C");
            letter = "C";
        }
        else if (userGradeNumber >= 60)
        {
            //Console.WriteLine("Your grade is: D");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("Your grade is: E");
            letter = "E";
        }

        Console.WriteLine($"Your garde is: {letter}");

        if (userGradeNumber >= 70)
        {
            Console.WriteLine("Congratulations you passed");
        }
        else
        {
            Console.WriteLine("You din't pass, but don't give up. Keep working hard, you will succeed");
        }

    }
}