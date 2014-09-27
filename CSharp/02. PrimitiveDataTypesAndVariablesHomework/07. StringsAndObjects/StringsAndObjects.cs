using System;

class StringsAndObjects
{
    static void Main()
    {
        string firststr = "Hello";
        string secondstr = "World";
        object both = firststr + " " + secondstr;
        string sentence = (string)both;
        Console.WriteLine(sentence);
    }
}