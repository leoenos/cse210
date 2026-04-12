public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        string _color = color;
        double _length = length;
        double _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}