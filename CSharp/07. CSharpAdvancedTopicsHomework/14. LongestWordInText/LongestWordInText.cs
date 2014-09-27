using System;

class LongestWordInText
{
	static void Main()
	{
		string someText = Console.ReadLine();
		string[] allWords = someText.Split(' ', ',', ':', ';', '.');
		int longestWordIndex = 0;
		for (int i = 1; i < allWords.Length; i++)
		{
			if (allWords[i].Length > allWords[longestWordIndex].Length)
			{
				longestWordIndex = i;
			}
		}
		Console.WriteLine(allWords[longestWordIndex]);
	}
}