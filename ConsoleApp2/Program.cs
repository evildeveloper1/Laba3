using System;
/*
* class Point
*/
class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}
/*
* class Figure
*/
class Figure
{
    private Point[] points;

    public Figure(params Point[] points)
    {
        if (points.Length < 3 || points.Length > 5)
        {
            throw new ArgumentException("A figure must have 3 to 5 points.");
        }
        this.points = points;
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }
        perimeter += GetSideLength(points[points.Length - 1], points[0]);

        Console.WriteLine($"Perimeter of the figure: {perimeter}");
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(0, 0, "A");
        Point p2 = new Point(0, 4, "B");
        Point p3 = new Point(3, 0, "C");

        Figure figure = new Figure(p1, p2, p3);
        figure.CalculatePerimeter();
    }
}
