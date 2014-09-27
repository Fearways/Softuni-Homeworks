using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("\nWeight on the earth : {0}\nWeight on the moon : {1}", weight, (weight * 17) / 100);
    }
}