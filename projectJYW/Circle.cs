using System.Xml.Serialization;
using static System.Console;

public class Circle
{
    private int _radius;

    public Circle(int radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    static void Main()
    {
        var circle1 = new Circle(10);
        WriteLine(circle1.GetArea());
        var circle2 = new Circle(5);
        WriteLine(circle2.GetArea());  
    }
}