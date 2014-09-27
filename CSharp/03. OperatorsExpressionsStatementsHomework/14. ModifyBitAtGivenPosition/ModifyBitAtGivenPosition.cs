using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter your number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Check bit of position");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Value of bit [0 or 1]");
        int v = int.Parse(Console.ReadLine());
        int mask = ~(1 << p);
        int mask1 = (1 << p);
        if (v == 0)
        {
            Console.WriteLine(n & mask);
        }
        if (v == 1)
        {
            Console.WriteLine(n | mask1);
        }
    }
}