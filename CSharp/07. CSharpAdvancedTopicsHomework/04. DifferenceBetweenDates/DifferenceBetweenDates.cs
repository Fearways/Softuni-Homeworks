using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime firstTime = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        DateTime secondTime = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        TimeSpan daysBetween = secondTime - firstTime;
        Console.WriteLine(daysBetween.Days);
    }
}