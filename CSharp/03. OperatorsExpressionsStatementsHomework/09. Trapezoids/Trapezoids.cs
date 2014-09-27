using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("\nArea of trapezoid is : " + ((a + b) / 2) * height);
    }
}