using System;
using System.Collections.Generic;

namespace The_Time_in_Words
{
    class Program
    {
        // Complete the timeInWords function below.
        public static string timeInWords(int hour, int minute)
        {
            Dictionary<int, string> hours = new Dictionary<int, string>()
            {
                { 1,"one"},
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eighth" },
                { 9, "nine" },
                { 10, "ten" },
                { 11, "eleven" },
                { 12, "twelve" }
            };
            Dictionary<int, string> minutes = new Dictionary<int, string>()
            {
                { 1, "one"},
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eighth" },
                { 9, "nine" },
                { 10, "ten" },
                { 11, "eleven" },
                { 12, "twelve" },
                { 13, "thirteen" },
                { 14, "fourteen" },
                { 15, "fifteen" },
                { 16, "sixteen" },
                { 17, "seventeen" },
                { 18, "eighteen" },
                { 19, "nineteen" },
                { 20, "twenty" },
                { 21, "twenty one" },
                { 22, "twenty two" },
                { 23, "twenty three" },
                { 24, "twenty four" },
                { 25, "twenty five" },
                { 26, "twenty six" },
                { 27, "twenty seven" },
                { 28, "twenty eighth" },
                { 29, "twenty nine" }

            };

            string timeinWord = string.Empty;
            var perfectMinute = Math.Abs(minute - 60);
            hour = hour == 12 ? 0 : hour;
            if (minute <= 30)
            {
                switch (minute)
                {
                    case 1:
                        timeinWord = String.Format("{0} minute past {1}", minutes[minute], hours[hour]);
                        break;
                    case 0:
                        timeinWord = String.Format("{0} o' clock", hours[hour]);
                        break;
                    case 15:
                        timeinWord = String.Format("quarter past {0}", hours[hour]);
                        break;
                    case 30:
                        timeinWord = String.Format("half past {0}", hours[hour]);
                        break;
                    default:
                        timeinWord = String.Format("{0} minutes past {1}", minutes[minute], hours[hour]);
                        break;
                }

            }
            else
            {
                switch (minute)
                {
                    case 59:
                        timeinWord = String.Format("{0} minute to {1}", minutes[perfectMinute], hours[++hour]);
                        break;
                    case 45:
                        timeinWord = String.Format("quarter to {0}", hours[++hour]);
                        break;
                    default:
                        timeinWord = String.Format("{0} minutes to {1}", minutes[perfectMinute], hours[++hour]);
                        break;
                }
            }
            return timeinWord;
        }


        static void Main(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());

            string result = timeInWords(h, m);

            Console.WriteLine(result);
        }
    }
}
