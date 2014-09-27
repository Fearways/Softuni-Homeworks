using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
	static void Main()
	{
		List<string> names = Console.ReadLine().Split(' ').ToList();
		List<string> namesRemove = Console.ReadLine().Split(' ').ToList(); ;
		for (int i = 0; i < namesRemove.Count; i++)
		{
			for (int j = 0; j < names.Count; j++)
			{
				if (namesRemove[i] == names[j])
				{
					names.RemoveAt(j);
					j--;
				}
			}
		}
		foreach (var nam in names)
		{
			Console.Write(nam);
			Console.Write(" ");
		}
	}
}