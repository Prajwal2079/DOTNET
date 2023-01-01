namespace GraphicsLibrary;

public class Rectangle : Shapes
{
    public Point Vertex1 { get; set; }

    public Point Vertex2 { get; set; }

    public Point Vertex3 { get; set; }
    public Rectangle(Point v1, Point v2, Point v3)
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
        double len1 = CalcLength(Vertex1, Vertex2);
        double len2 = CalcLength(Vertex2, Vertex3);

        return (len1 * len2);
    }

    public override double Perimeter()
    {
        double len1 = CalcLength(Vertex1, Vertex2);
        double len2 = CalcLength(Vertex2, Vertex3);

        return 2 * (len1 + len2);
    }

    public override string ToString()
    {
        return $"Area of Rectangle = {Math.Truncate(Area())}  Perimeter of Rectangle = {Math.Truncate(Perimeter())}";
    }

}