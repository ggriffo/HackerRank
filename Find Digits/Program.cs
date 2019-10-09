using System;

namespace Find_Digits
{
    class Program
    {
        static int findDigits(int n)
        {
            int totalDivision = 0;
            string value = n.ToString();

            for (int i = 0; i < value.Length; i++)
            {
                if ((value[i].ToString() != "0") && (n % Convert.ToInt32(value[i].ToString()) == 0))
                    totalDivision++;
            }

            return totalDivision;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                Console.WriteLine(result);
            }
        }
    }
}
