using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public static class ShortestSubarray
    {
        public static int Method(int[] nums, int k)
        {
            bool thereIsArray = false;
            int min = int.MaxValue;

            LinkedListNode<int> 

            for (int i = 0; i < nums.Length; i++)
            {
                int counter = 1;
                int sum = nums[i];
                if ((sum >= k) && (counter < min))
                {
                    min = counter;
                    thereIsArray = true;
                }

                for (int x = i+1; x < nums.Length; x++)
                {
                    sum += nums[x];
                    counter++;
                    if ((sum >= k) && (counter < min))
                    {
                        min = counter;
                        sum = 0;
                        thereIsArray = true;
                        counter = 0;
                    }                    
                }                
            }

            return (!thereIsArray ? -1 : min);
        }
    }
}
