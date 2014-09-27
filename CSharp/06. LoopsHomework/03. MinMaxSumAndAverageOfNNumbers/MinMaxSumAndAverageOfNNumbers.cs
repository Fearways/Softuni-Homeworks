using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        decimal average = 0m;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            min = Math.Min(min, number);
            max = Math.Max(max, number);
            sum += number;
        }
        average = (decimal)sum / n;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\naverage = {3:F}",min,max,sum,average);
    }
}