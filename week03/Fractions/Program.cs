using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Fraction number = new Fraction();

        Console.WriteLine(number.GetFractionString());
        Console.WriteLine(number.GetDecimalValue());

        Fraction number2 = new(5);

        Console.WriteLine(number2.GetFractionString());
        Console.WriteLine(number2.GetDecimalValue());

        Fraction number3 = new(3, 4);


        Console.WriteLine(number3.GetFractionString());
        Console.WriteLine(number3.GetDecimalValue());

        Fraction number4 = new(1,3);

        Console.WriteLine(number4.GetFractionString());
        Console.WriteLine(number4.GetDecimalValue());

    }
}