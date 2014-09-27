using System;
using System.Collections.Generic;

class RandomizeTheNumbersFrom1ToN
{
	static void Main()
	{
		Random r = new Random();
		List<int> result = new List<int>();
		int n = int.Parse(Console.ReadLine());
		while (result.Count < n)
		{
			int number = r.Next(1, n + 1);
			if (!result.Contains(number))
			{
				result.Add(number);
			}
		}
		foreach (var num in result)
		{
			Console.Write(num + " ");
		}
		Console.WriteLine();
	}
}