using System;

class PointInsideCircleAndOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter X :");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y :");
        double y = double.Parse(Console.ReadLine());
        bool inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 2.25;
        bool outRectangle = x < -1 || x > 5 || y > 1 || y < -1;
        Console.WriteLine("{0}", inCircle && outRectangle);
    }
}