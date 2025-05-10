using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string newNumber;

        int maxNumber;
        maxNumber = 0;

        double average;
        average = 0;

        double totalSum;
        totalSum = 0;

        do
        {
            Console.WriteLine("Enter a series of numbers to the list. Enter 0 to finish");
            newNumber = Console.ReadLine();
            int userNewNumber = int.Parse(newNumber);

            if (userNewNumber > 0)
            {
                numbers.Add(userNewNumber);
            }
            else if (userNewNumber == 0)
            {
                break;
            }
        } while (newNumber != "0");

        foreach (int number in numbers)
        {
            totalSum += number;

            average = totalSum / numbers.Count;

            if (maxNumber < number)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}