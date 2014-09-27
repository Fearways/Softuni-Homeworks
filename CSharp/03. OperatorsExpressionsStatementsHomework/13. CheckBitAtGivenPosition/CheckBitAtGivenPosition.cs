using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine("Bit of position {0} is '1' = {1}", p, bit==1);
    }
}