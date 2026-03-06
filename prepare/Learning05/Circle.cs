public class Circle : Shape
{
    private double _radius;

    public Circle(){}
    public Circle(double radius)
    {
        _radius = radius;
    }

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2.0);
    }
}