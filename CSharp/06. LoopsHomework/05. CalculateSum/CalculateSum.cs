using System;

class CalculateSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        ulong factoriel = 1;
        decimal sum = 1m;
        for (int i = 1; i <= n; i++)
        {
            factoriel *= (ulong)i;
            sum += factoriel / (decimal)Math.Pow(x, i);
        }
        Console.WriteLine("{0:F5}",sum);
    }
}