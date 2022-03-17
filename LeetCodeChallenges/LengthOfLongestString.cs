using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public class LengthOfLongestString
    {
        public int LengthOfLongestSubstring(string s)
        {
            string word = "";
            int max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!word.Contains(s[i]))
                {
                    word += s[i].ToString();
                }
                else
                {
                    if (word.Length > max)
                    {
                        max = word.Length;                        
                    }

                    word = word.Substring(word.IndexOf(s[i]) + 1, word.Length - word.IndexOf(s[i]) - 1);
                    word += s[i].ToString();
                }
            }

            return (word.Length > max ? word.Length : max);
        }
    }
}
