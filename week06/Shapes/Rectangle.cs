public class Rectangle : Shape
{
    private double _height;
    private double _side;

    //Constructor
    public Rectangle(string color, double height, double width) : base(color)
    {
        _height = height;
        _side = width;
        
    }

    public override double GetArea()
    {
        return _height * _side;
    }
}