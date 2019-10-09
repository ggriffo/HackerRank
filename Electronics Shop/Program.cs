using System;
using System.Collections.Generic;
using System.Linq;

namespace Electronics_Shop
{
    class Program
    {
        static int getMoneySpent(int[] k, int[] d, int budget)
        {
            List<int> keyboards = k.ToList();
            keyboards.Sort();

            List<int> drives = d.ToList();
            drives.Sort();

            double rest = double.MinValue;
            int spent = -1;

            for (int i = keyboards.Count -1; i >= 0; i--)
            {
                for (int x = drives.Count -1; x >= 0; x--)
                {
                    if (drives[x] + keyboards[i] == budget)
                        return budget;
                    else
                    {
                        if ((drives[x] + keyboards[i] < budget) && (((Convert.ToDouble(drives[x]) + Convert.ToDouble(keyboards[i])) / budget > rest)))
                        {
                            spent = drives[x] + keyboards[i];
                            rest = (Convert.ToDouble(drives[x]) + Convert.ToDouble(keyboards[i])) / budget;
                        }
                    }
                }
            }
            
            return spent;
        }

        static void Main(string[] args)
        {

            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));


            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);
        }
    }
}
