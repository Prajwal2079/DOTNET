using GraphicsLibrary;

internal class Program
{
    public static Point AccecptCoordinates()
    {
        return new Point(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
    }
    private static void Main(string[] args)
    {
        SortedList<Int32, Shapes> shapesList = new SortedList<Int32, Shapes>();
        Point p1, p2, p3;
        int choice, count = 0;

        do
        {
            Console.WriteLine("Make a choice.\n1.Circle\n2.Triangle\n3.Rectangle\n4.Display all shapes\n5.Exit");
            choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter two coordinate for Circle");
                    Console.WriteLine("Enter x and y coordinates for center of Circle");
                    p1 = AccecptCoordinates();

                    Console.WriteLine("Enter x and y coordinates for any point on the Circle");
                    p2 = AccecptCoordinates();

                    Shapes circle = new Circle(p1, p2);
                    count++;
                    shapesList.Add(count, circle);
                    Console.WriteLine(circle);
                    break;

                case 2:
                    Console.WriteLine("Enter three coordinate for Triangle");
                    Console.WriteLine("Coordinate 1");
                    p1 = AccecptCoordinates();

                    Console.WriteLine("Coordinate 2");
                    p2 = AccecptCoordinates();

                    Console.WriteLine("Coordinate 3");
                    p3 = AccecptCoordinates();

                    Shapes triangle = new Triangle(p1, p2, p3);
                    count++;
                    shapesList.Add(count, triangle);
                    Console.WriteLine(triangle);
                    break;

                case 3:
                    Console.WriteLine("Enter three coordinate for Rectangle");
                    Console.WriteLine("Coordinate 1");
                    p1 = AccecptCoordinates();

                    Console.WriteLine("Coordinate 1");
                    p2 = AccecptCoordinates();

                    Console.WriteLine("Coordinate 1");
                    p3 = AccecptCoordinates();

                    Shapes rectangle = new Rectangle(p1, p2, p3);
                    count++;
                    shapesList.Add(count, rectangle);
                    Console.WriteLine(rectangle);
                    break;

                case 4:
                    Console.WriteLine("Display all shapes");
                    foreach (KeyValuePair<Int32, Shapes> s in shapesList)
                    {
                        Console.WriteLine(s.Key + ". " + s.Value);
                    }
                    break;

                case 5:
                    Console.WriteLine("Thankyou");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 4);
    }
}