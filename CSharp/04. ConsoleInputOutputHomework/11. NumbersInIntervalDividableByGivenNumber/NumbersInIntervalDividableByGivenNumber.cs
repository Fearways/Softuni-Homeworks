using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Enter start number");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter stop number");
        int stop = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = Math.Min(start, stop); i <= Math.Max(start, stop); i++) 
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}