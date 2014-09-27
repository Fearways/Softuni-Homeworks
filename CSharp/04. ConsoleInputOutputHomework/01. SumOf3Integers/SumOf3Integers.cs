using System;

class SumOf3Integers
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        decimal c = decimal.Parse(Console.ReadLine());
        Console.WriteLine(a+b+c);
    }
}
