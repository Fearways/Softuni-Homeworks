using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n");
        int n = int.Parse(Console.ReadLine());
        ulong firstNumber = 0;
        ulong secondNumber = 1;
        ulong thirdNumber;
        if (n == 1)
        {
            Console.WriteLine(0);
        }
        else if (n == 2)
        {
            Console.WriteLine(0 + " " + 1);
        }
        else
        {
            Console.Write(0 + " " + 1);
            for (int i = 2; i < n; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                Console.Write(" "+thirdNumber);
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
            Console.Write("\n");
        }
    }
}