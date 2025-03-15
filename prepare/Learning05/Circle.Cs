public class Circle : Shape
{
    private double _radius;

    public Circle(string color, string shape, double radius) : base (color, shape)
    {
        _radius = radius;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}