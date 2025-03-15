using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapesList = new List<Shape>();

        Square square1 = new Square("Blue", "square", 5);
        shapesList.Add(square1);

        Rectangle rectangle1 = new Rectangle("Yellow", "rectangle", 2, 7);
        shapesList.Add(rectangle1);

        Circle circle1 = new Circle("Green", "circle", 6);
        shapesList.Add(circle1);

        Triangle triangle1 = new Triangle("Purple", "triangle", 10, 15);
        shapesList.Add(triangle1);

        foreach (Shape s in shapesList)
        {
            string color = s.GetColor();

            string shape = s.GetShape();

            double area = s.GetArea();

            Console.WriteLine($"The {color} {shape} has an area of {area}.");
        }
    }
}