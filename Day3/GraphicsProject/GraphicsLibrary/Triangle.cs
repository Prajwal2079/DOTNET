using System;
namespace GraphicsLibrary;

public class Triangle : Shapes
{
    public Point Vertex1 { get; set; }

    public Point Vertex2 { get; set; }

    public Point Vertex3 { get; set; }
    public Triangle(Point v1, Point v2, Point v3)
    {
        this.Vertex1 = v1;
        this.Vertex2 = v2;
        this.Vertex3 = v3;
    }

    private double CalcLength(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
    }
    public override double Area()
    {
        return 12 * (Vertex1.X * (Vertex2.Y - Vertex3.Y) + Vertex2.X * (Vertex3.Y - Vertex1.Y) + Vertex3.X * (Vertex1.Y - Vertex2.Y));
    }

    public override double Perimeter()
    {
        double len1 = CalcLength(Vertex1, Vertex2);
        double len2 = CalcLength(Vertex2, Vertex3);
        double len3 = CalcLength(Vertex3, Vertex1);

        return (len1 + len2 + len3);
    }

    public override string ToString()
    {
        return $"Area of Triangle = {Math.Truncate(Area())}  Perimeter of Triangle = {Math.Truncate(Perimeter())}";
    }
}
