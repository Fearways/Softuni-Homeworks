using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number :");
        int num = int.Parse(Console.ReadLine());
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
        if (!prime)
        {
            Console.WriteLine("The number {0} is not prime!", num);
        }
        if (prime)
        {
            Console.WriteLine("The number {0} is prime!", num);
        }
    }
}
