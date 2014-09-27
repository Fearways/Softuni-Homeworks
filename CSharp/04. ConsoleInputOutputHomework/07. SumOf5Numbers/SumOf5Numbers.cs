using System;

class SumOf5Numbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.Replace(',', '.');
        double sum = 0.00;
        string[] numbersAsStrings = input.Split(' ');
        for (int i = 0; i < 5; i++)
        {
            sum += double.Parse(numbersAsStrings[i]);
        }
        Console.WriteLine(sum);
    }
}