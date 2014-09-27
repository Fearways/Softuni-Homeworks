using System;

class PrimeChecker
{
    static void Main()
    {
        Console.Write("Please enter an integer number : ");
		long num = long.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} is prime : {1}", num, IsPrime(num));
    }

	static bool IsPrime(long num)
    {
        int sqrt = (int)Math.Sqrt(num);
        int i = 2;
        bool prime = true;
        while (prime && i <= sqrt)
        {
            if (num % i == 0)
            {
                prime = false;
            }
            i++;
        }
        if (num <= 1)
        {
            prime = false;
        }
        return prime;
    }
}