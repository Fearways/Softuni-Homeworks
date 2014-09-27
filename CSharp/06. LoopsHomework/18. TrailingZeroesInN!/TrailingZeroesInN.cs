using System;
using System.Numerics;

class TrailingZeroesInN
{
	static void Main()
	{
		Console.Write("Please, enter a positive number for N = ");
		uint numN = uint.Parse(Console.ReadLine());
		BigInteger factorialN = 1;
		for (int i = 2; i <= numN; i++)
		{
			factorialN *= i;
		}
		long countZeroes = 0;
		long divider = 5;
		int k = 1;
		while ((numN / divider) >= 1)
		{
			countZeroes += (numN / divider);
			divider *= 5;
			k++;
		}
		Console.WriteLine("The Factorial from that number N is N! = {0}", factorialN);
		Console.WriteLine("The Trailing Zeroes in that N Factorial is ZEROES = {0}", countZeroes);
	}
}
