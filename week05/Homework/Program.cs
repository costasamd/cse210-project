using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment newAssing = new("Jake", "Percentage", "8.5", "1-5");

        Console.WriteLine(newAssing.GetSumary());
        Console.WriteLine(newAssing.GetHomeWorkList());

        WritingAssignment newWriting = new("Maria Lorcana", "Fench Revolution", "How the French Revolution affected the world");

        Console.WriteLine(newWriting.GetWritingInformation());
    }
}