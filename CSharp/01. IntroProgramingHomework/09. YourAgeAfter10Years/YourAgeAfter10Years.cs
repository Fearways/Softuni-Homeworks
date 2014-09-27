using System;

class YourAgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Write your Birthday (date.month.year): ");
        String birthday = Console.ReadLine();
        String[] birthday1 = birthday.Split(',');
        int day = int.Parse(birthday1[0]);
        int mounth = int.Parse(birthday1[1]);
        int year = int.Parse(birthday1[2]);
        DateTime currentdate = DateTime.Now;
        int currentday = currentdate.Day;
        int currentmounth = currentdate.Month;
        int currentyear = currentdate.Year;
        int age = 0;
        if (currentmounth >= mounth)
        {
            if (currentday >= day)
            {
                age = currentyear - year;
            }
        }
        else
        {
            age = currentyear - year - 1;
        }
        Console.WriteLine(age+10);
    }
}
