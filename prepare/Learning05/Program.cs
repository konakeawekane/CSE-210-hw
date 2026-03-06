using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.AddRange(
            new Square(4.0, "red"),
            new Rectangle(2.0, 3.0, "blue"),
            new Circle(5.0, "green")
        );

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.GetColor()} Shape Area: {shape.GetArea()}");
        }

    }
}