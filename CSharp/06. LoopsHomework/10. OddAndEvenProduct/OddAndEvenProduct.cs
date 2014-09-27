using System;

class OddAndEvenProduct
{
	static void Main()
	{
		string numbers = Console.ReadLine();
		string[] number = numbers.Split(' ');
		int evenProduct = 1;
		int oddProduct = 1;
		for (int i = 0; i < number.Length; i++)
		{
			if (i % 2 == 0)
			{
				oddProduct *= int.Parse(number[i]);
			}
			else if (i % 2 == 1)
			{
				evenProduct *= int.Parse(number[i]);
			}
		}
		if (oddProduct == evenProduct)
		{
			Console.WriteLine("yes");
			Console.WriteLine("Product = {0}", evenProduct);
		}
		if (oddProduct != evenProduct)
		{
			Console.WriteLine("no");
			Console.WriteLine("odd product = {0}", oddProduct);
			Console.WriteLine("even product = {0}", evenProduct);
		}
	}
}