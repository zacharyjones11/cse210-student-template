using System;

class Program
{
    static void Main(string[] args)
    {
         List<Shape> shapes = new List<Shape>();

        // Add shapes to the list
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        // Iterate through the list and display each shape's color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }
    }
}

class Shape
{
    private string _color;

    // Manual getter method
    public string GetColor()
    {
        return _color;
    }

    // Manual setter method
    public void SetColor(string color)
    {
        _color = color;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}

class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}

class Rectangle : Shape
{
    private double _side;
    private double _sideTwo;

    public Rectangle(string color, double side, double sideTwo) : base(color)
    {
        _side = side;
        _sideTwo = sideTwo;
    }

    public override double GetArea()
    {
        return _side * _sideTwo;
    }
}

    class Circle : Shape
{
    private double _radius;
    private const double PI = 3.14;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return PI * _radius * _radius;
    }
}
