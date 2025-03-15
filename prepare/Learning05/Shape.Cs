public abstract class Shape
{
    private string _color;
    private string _shape;

    public Shape(string color, string shape)
    {
        _shape = shape;
        _color = color;
    }

    public string GetShape()
    {
        return _shape;
    }

    public void SetShape(string shape)
    {
        _shape = shape;
    }

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