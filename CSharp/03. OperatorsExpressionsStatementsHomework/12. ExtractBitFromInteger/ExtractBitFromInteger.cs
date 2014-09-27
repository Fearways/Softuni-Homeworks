using System;

class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine(bit);
    }
}
