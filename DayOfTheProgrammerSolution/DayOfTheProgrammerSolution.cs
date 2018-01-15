using System;

class Solution
{

    static string solve(int year)
    {
        int sumExceptFebruary = 31 + 31 + 30 + 31 + 30 + 31 + 31;
        int day = 0;
        int februaryDays = 0;
        int removeDays = 0;
        if (year >= 1919)
        {
            februaryDays = DateTime.DaysInMonth(year, 2);
        }
        else if(year == 1918)
        {
            removeDays = 13;
            februaryDays = DateTime.DaysInMonth(year, 2);
        }
        else if(year < 1918)
        {
            if(year % 4 == 0)
            {
                februaryDays = 29;
            }
            else
            {
                februaryDays = 28;
            }
        }

        day = 256 - (sumExceptFebruary + februaryDays);
        DateTime date = new DateTime(year, 9, day).AddDays(removeDays);
        string result = date.ToString("dd.MM.yyyy");
        return result;
    }

    static void Main(String[] args)
    {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = solve(year);
        Console.WriteLine(result);
    }
}
