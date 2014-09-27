using System;
using System.Numerics;

class CatalanNumbers
{
	static void Main()
	{
		uint n = uint.Parse(Console.ReadLine());
		BigInteger nfactoriel = 1;
		BigInteger nplusonefactoriel = 1;
		BigInteger twoNfactoriel = 1;
		for (uint i = 1; i <= n; i++)
		{
			nfactoriel *= i;
		}
		for (uint i = 1; i <= 2 * n; i++)
		{
			twoNfactoriel *= i;
		}
		for (uint i = 1; i <= n + 1; i++)
		{
			nplusonefactoriel *= i;
		}
		Console.WriteLine("{0}", twoNfactoriel / (nplusonefactoriel * nfactoriel));
	}
}