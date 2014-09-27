using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n");
        int n = int.Parse(Console.ReadLine());
        double sum = 0.00;
        for (int i = 0; i < n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}
