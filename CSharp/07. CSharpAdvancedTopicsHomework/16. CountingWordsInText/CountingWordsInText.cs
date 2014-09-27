using System;

class CountingWordsInText
{
	static int CompareWords(string inputWord, string inputText)
	{
		string[] allWords = inputText.Split(' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')');
		int counter = 0;
		for (int i = 0; i < allWords.Length; i++)
		{
			if (string.Equals(allWords[i], inputWord, StringComparison.OrdinalIgnoreCase))
			{
				counter++;
			}
		}
		return counter;
	}
	static void Main()
	{
		string keyWord = Console.ReadLine();
		string someText = Console.ReadLine();
		int result = CompareWords(keyWord, someText);
		Console.WriteLine(result);
	}
}