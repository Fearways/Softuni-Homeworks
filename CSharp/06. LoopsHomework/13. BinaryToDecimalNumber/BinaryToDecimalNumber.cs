using System;

class BinaryToDecimalNumber
{
	static void Main()
	{
		string number = Console.ReadLine();
		long finalNumber = 0;
		int power = 1;
		for (int i = number.Length - 1; i >= 0; i--)
		{
			finalNumber += (number[i] - 48) * power;
			power *= 2;
		}
		Console.WriteLine(finalNumber);
	}
}