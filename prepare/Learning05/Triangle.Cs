public class Triangle : Shape
{
    private double _basetri;
    private double _height;

    public Triangle(string color, double basetri, double height) : base (color)
    {
        _basetri = basetri;
        _height = height;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return  _basetri * _height / 2;
    }
}