using System;

namespace GraphicsLibrary;
public class Circle : Shapes
{
    public Point Center { get; set; }

    public Point PointOnCircle { get; set; }
    public Circle(Point center, Point pointOnCir)
    {
        this.Center = center;
        this.PointOnCircle = pointOnCir;
    }

    private double CalcRadius()
    {
        return Math.Sqrt(Math.Pow((Center.X - PointOnCircle.X), 2) + Math.Pow((Center.Y - PointOnCircle.Y), 2));
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(CalcRadius(), 2);
    }

    public override double Perimeter()
    {
        return (2 * Math.PI * CalcRadius());
    }

    public override string ToString()
    {
        return $"Area of Circle = {Math.Truncate(Area())}  Perimeter of Circle = {Math.Truncate(Perimeter())}";
    }
}