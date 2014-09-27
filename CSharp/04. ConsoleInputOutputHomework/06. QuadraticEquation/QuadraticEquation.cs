using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = (Math.Pow(b, 2)) - (4 * a * c);
        if(d < 0)
        {
            Console.WriteLine("No real roots");
            return;
        }
        if (d == 0) 
        {
            Console.WriteLine("x1=x2={0}", (- b) / (2 * a));
        }
        if (d > 0) 
        {
            Console.WriteLine("x1={0},x2={1}", ((-b) - (Math.Sqrt(d))) / (2 * a), ((-b) + (Math.Sqrt(d))) / (2 * a));
        }
    }
}