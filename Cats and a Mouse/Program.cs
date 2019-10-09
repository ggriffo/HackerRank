using System;

namespace Cats_and_a_Mouse
{
    class Program
    {
        static string catAndMouse(int x, int y, int z)
        {
            if (Math.Abs(x - z) < Math.Abs(y - z))
                return "Cat A";
            else if (Math.Abs(y - z) < Math.Abs(x - z))
                return "Cat B";
            else
                return "Mouse C";
        }

        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                Console.WriteLine(result);
            }
        }
    }
}
