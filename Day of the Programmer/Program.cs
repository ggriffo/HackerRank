using System;

namespace Day_of_the_Programmer
{
    class Program
    {
        static string dayOfProgrammer(int year)
        {
            DateTime date = new DateTime(year, 8, 31);

            do
            {
                date = date.AddDays(1);

            } while (date.DayOfYear != 256);

            if (year < 1918 && year % 4 == 0 && !DateTime.IsLeapYear(date.Year))
            {
                date = date.AddDays(-1);
            }
            else if (year == 1918)
            {
                date = date.AddDays(13);
            }

            return date.ToString("dd.MM.yyyy");
        }

        static void Main(string[] args)
        {
        
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = dayOfProgrammer(year);

            Console.WriteLine(result);
        }
    }
}
