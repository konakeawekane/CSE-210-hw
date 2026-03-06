public class Square : Shape
{
    private double _side;

    public Square(){}
    public Square(double sideLength)
    {
        _side = sideLength;
    }

    public Square(double sideLength, string color) : base(color)
    {
        _side = sideLength;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}