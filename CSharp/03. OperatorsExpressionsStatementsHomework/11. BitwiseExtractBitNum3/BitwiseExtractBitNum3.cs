using System;

class BitwiseExtractBitNum3
{
    static void Main()
    {
        int p = 3;
        int n = int.Parse(Console.ReadLine());          
        int nRightP = n >> p;
        int bit = nRightP & 1;     
        Console.WriteLine(bit);
    }
}