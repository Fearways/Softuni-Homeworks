using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(Math.Max(a,b),c));
    }
}