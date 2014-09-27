using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int choose = int.Parse(Console.ReadLine());
        switch (choose)
        {
            case 1:
                Console.WriteLine("Please enter a int:");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(intNumber + 1);
                break;
            case 2:
                Console.WriteLine("Please enter a double:");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string:");
                string text = Console.ReadLine();
                Console.WriteLine(text + "*");
                break;
        }
    }
}
