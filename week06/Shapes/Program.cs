using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new("blue", 5.5);
        Circle cr = new("yellow", 3.7);
        Rectangle rct = new("purple", 4, 6.6);

        List<Shape> figure = new List<Shape>();

        figure.Add(sq);
        figure.Add(cr);
        figure.Add(rct);

        foreach (Shape shape in figure)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The shape {color} has area of {area}");
        }
    }
}