using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace Migratory_Birds
{
    class Program
    {
        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {
            arr.Sort();

            int total = 0;
            int previous = 0;
            int grandTotal = 0;
            int minNumber = 0;

            for (int i = 1; i < arr.Count; i++)
            {
                previous = arr[i - 1];

                if (arr[i] == previous)
                {
                    total++;
                }
                
                if (total > grandTotal)
                {
                    grandTotal = total;
                    minNumber = arr[i - 1];
                }

                if (arr[i] != previous)
                    total = 0;
            }

            return minNumber;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
