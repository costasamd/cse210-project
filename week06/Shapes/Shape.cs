using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

public abstract class Shape
{
    private string _color;

    //constructor

    public Shape(string color)
    {
        _color = color;
    }

    //getter and setter

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
    
}