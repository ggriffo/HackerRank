using System;

namespace Counting_Valleys
{
    class Program
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int garyLevel = 0;
            bool belowSeaLevel = false;
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'D')
                    garyLevel--;
                else
                    garyLevel++;

                if (garyLevel == 0)
                    belowSeaLevel = false;

                if (!belowSeaLevel && garyLevel < 0)
                {
                    count++;
                    belowSeaLevel = true;
                }                    
            }

            return count;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);
        }
    }
}
