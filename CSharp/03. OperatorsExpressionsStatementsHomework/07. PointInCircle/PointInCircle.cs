using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter X :");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y :");
        double y = double.Parse(Console.ReadLine());
        bool inCircle = x * x + y * y <= 4;
        Console.WriteLine("These coordinates are inside the circle = {0}", inCircle);
    }
}