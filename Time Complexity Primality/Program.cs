using System;

namespace Time_Complexity_Primality
{
    class Program
    {
        // Complete the primality function below.
        static string primality(int n)
        {
            if (n == 1)
            {
                return "Not prime";
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return "Not prime";
                }
            }
            return "Prime";
        }

        static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());

            for (int pItr = 0; pItr < p; pItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                string result = primality(n);

                Console.WriteLine(result);
            }
        }
    }
}
