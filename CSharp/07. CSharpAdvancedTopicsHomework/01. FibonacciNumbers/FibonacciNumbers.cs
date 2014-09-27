using System;

class FibonacciNumbers
{
    static ulong Fib(int n)
    {
        ulong firstNumber = 1;
        ulong secondNumber = 2;
        ulong thirdNumber = 0;
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
        }
        return secondNumber;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }
}