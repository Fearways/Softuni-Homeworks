using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
	static void Main()
	{
		string lettersString = Console.ReadLine();
		string[] allNames = lettersString.Split(' ');
		List<string> Names = allNames.ToList<string>();
		Names.Sort();
		int counter = 1;
		for (int i = 1; i < Names.Count; i++)
		{
			if (Names[i] == Names[i - 1])
			{
				counter++;
			}
			else
			{
				Console.WriteLine("{0} -> {1}", Names[i - 1], counter);
				counter = 1;
			}
			if (i == Names.Count - 1)
			{
				Console.WriteLine("{0} -> {1}", Names[i], counter);
			}
		}
	}
}