using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public class StringFunctionCalculation
    {
        public static int maxValue(string t)
        {
            int max = 0;
            int n = t.Length;

            for (int length = 1; length <= n; length++)
            {
                Dictionary<string, int> substringCount = new Dictionary<string, int>();

                for (int i = 0; i <= n - length; i++)
                {
                    string substring = t.Substring(i, length);

                    if (substringCount.ContainsKey(substring))
                    {
                        substringCount[substring]++;
                    }
                    else
                    {
                        substringCount[substring] = 1;
                    }

                    int value = substringCount[substring] * length;
                    if (value > max)
                    {
                        max = value;
                    }
                }
            }

            return max;
        }

        public static void checkMagazine(List<string> magazine, List<string> note)
        {
            if (note.Count > magazine.Count)
            {
                Console.Write("No");
                return;
            }

            bool containsAll = true;
            foreach (var word in note)
            {
                int index = magazine.FindIndex(maxValue => maxValue == word);
                if (index == -1)
                {
                    containsAll = false;
                    break;
                }
                magazine.RemoveAt(index);
            }

            Console.Write(containsAll ? "Yes" : "No");
        }

        public static void checkMagazine2(List<string> magazine, List<string> note)
        {
            Dictionary<string, int> magazineWordCount = new Dictionary<string, int>();

            // Count the occurrences of each word in the magazine
            foreach (var word in magazine)
            {
                if (magazineWordCount.ContainsKey(word))
                {
                    magazineWordCount[word]++;
                }
                else
                {
                    magazineWordCount[word] = 1;
                }
            }

            // Check if the note can be constructed from the magazine
            foreach (var word in note)
            {
                if (magazineWordCount.ContainsKey(word) && magazineWordCount[word] > 0)
                {
                    magazineWordCount[word]--;
                }
                else
                {
                    Console.Write("No");
                    return;
                }
            }

            Console.Write("Yes");
        }
    }
}