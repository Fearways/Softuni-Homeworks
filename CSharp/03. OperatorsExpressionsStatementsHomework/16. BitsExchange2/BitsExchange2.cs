using System;

class BitsExchange2
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        ulong number = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter p");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter q");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k");
        int k = int.Parse(Console.ReadLine());
        uint maskNumber = 0;
        if (Math.Max(p, q) + k > 32)
        {
            Console.WriteLine("out of range");
        }
        else if (Math.Min(p, q) + k > Math.Max(p, q))
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            for (int i = 0; i < k; i++)
            {
                maskNumber += (uint)Math.Pow(2, i);
            }

            uint mask = ((maskNumber << p) | (maskNumber << q));
            uint firstBitGroup = (uint)((number >> p) & maskNumber);
            uint secondBitGroup = (uint)((number >> q) & maskNumber);
            Console.WriteLine((number & (~mask)) | ((firstBitGroup << q) | (secondBitGroup << p)));
        }
    }
}