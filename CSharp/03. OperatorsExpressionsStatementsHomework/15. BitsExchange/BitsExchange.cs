using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        uint number = uint.Parse(Console.ReadLine());
        uint mask = ((7 << 3) | (7 << 24));
        uint firstBitGroup = (number >> 3) & 7;
        uint secondBitGroup = (number >> 24) & 7;
        Console.WriteLine((number & (~mask)) | ((firstBitGroup << 24) | (secondBitGroup << 3)));
    }
}