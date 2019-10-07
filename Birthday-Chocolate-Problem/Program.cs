using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Chocolate_Problem
{
    class Program
    {
        static int Birthday(List<int> s, int d, int m)
        {
            int result = 0;
            for (int i = 0; i < s.Count; i++)
            {
                if (i <= s.Count - m)
                {
                    if (d == s.Skip(i).Take(m).Sum())
                        result++;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {

            //hackerrank link: https://www.hackerrank.com/challenges/the-birthday-bar/problem

            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = Birthday(s, d, m);

            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
