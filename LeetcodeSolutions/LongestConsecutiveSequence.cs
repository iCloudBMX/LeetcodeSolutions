using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
    internal class LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            var hashSet = new HashSet<int>(nums);

            int maxLength = 0;

            foreach(var num in nums)
            {
                if (hashSet.Contains(num - 1))
                    continue;
                else
                {
                    int start = num;
                    int length = 0;

                    while(hashSet.Contains(start))
                    {
                        start++;
                        length++;
                    }
                    maxLength = Math.Max(maxLength, length);
                }
            }
            
            return maxLength;
        }
    }
}
