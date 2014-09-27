using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
	static void Main()
	{
		List<string> numbers = Console.ReadLine().Split(' ').ToList();
		List<string> removeNumbers = Console.ReadLine().Split(' ').ToList();
		RemoveEqualNumbers(removeNumbers, numbers);
		numbers.AddRange(removeNumbers);
		numbers.Sort();
		PrintNumbers(numbers);
	}

	static void RemoveEqualNumbers(List<string> removeNumbers, List<string> numbers)
	{
		for (int i = 0; i < removeNumbers.Count; i++)
		{
			for (int j = 0; j < numbers.Count; j++)
			{
				if (removeNumbers[i] == numbers[j])
				{
					numbers.RemoveAt(j);
					j--;
				}
			}

		}
	}

	static void PrintNumbers(List<string> numbers)
	{
		foreach (var item in numbers)
		{
			Console.Write(item + " ");
		}
		Console.WriteLine();
	}
}
