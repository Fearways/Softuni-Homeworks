using System;
using System.Numerics;

class CalculateNDevidedK
{
	static void Main()
	{
		BigInteger n = BigInteger.Parse(Console.ReadLine());
		BigInteger k = BigInteger.Parse(Console.ReadLine());
		BigInteger factoriel = 1;
		for (BigInteger i = 1; i <= n; i++)
		{
			factoriel *= i;
			if (i == k)
			{
				k = factoriel;
			}
		}
		n = factoriel;
		Console.WriteLine("{0}", n / k);
	}
}
