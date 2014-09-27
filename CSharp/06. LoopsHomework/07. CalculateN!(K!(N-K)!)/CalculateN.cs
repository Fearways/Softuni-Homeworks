using System;
using System.Numerics;

class CalculateN
{
	static void Main()
	{
		Console.BufferHeight = 10000;
		ulong n = ulong.Parse(Console.ReadLine());
		ulong k = ulong.Parse(Console.ReadLine());
		BigInteger nfactoriel = 1;
		BigInteger kfactoriel = 1;
		BigInteger nminuskfactoriel = 1;
		for (ulong i = 1; i <= n; i++)
		{
			nfactoriel *= i;
			if (i == k)
			{
				kfactoriel = nfactoriel;
			}
		}
		for (ulong i = 1; i <= n - k; i++)
		{
			nminuskfactoriel *= i;
		}
		Console.WriteLine("{0}", nfactoriel / (kfactoriel * nminuskfactoriel));
	}
}