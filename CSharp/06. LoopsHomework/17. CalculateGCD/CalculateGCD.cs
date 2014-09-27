using System;

class CalculateGCD
{
	static void Main()
	{
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int Remainder;
		while (b != 0)
		{
			Remainder = a % b;
			a = b;
			b = Remainder;
		}
		Console.WriteLine(a);
	}
}
