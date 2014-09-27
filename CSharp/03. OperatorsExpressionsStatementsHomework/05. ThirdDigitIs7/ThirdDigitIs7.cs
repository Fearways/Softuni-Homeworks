using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if ((number / 100) % 10 == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}