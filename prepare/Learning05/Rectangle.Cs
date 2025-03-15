public class Rectangle : Shape
{
    private double _width;
    private double _length;

    public Rectangle(string color, string shape, double width, double length) : base (color, shape)
    {
        _width = width;
        _length = length;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _width * _length;
    }
}
