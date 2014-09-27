using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter width");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height");
        double height = double.Parse(Console.ReadLine());
        double perimeter = (width * 2) + (height * 2);
        double area = width * height;
        Console.WriteLine("\nWidth : {0}\nHeight : {1}\nPerimeter : {2}\nArea : {3}", width, height, perimeter, area);
    }
}