using System;

namespace LeetcodeSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

            LongestConsecutiveSequence longestConsecutiveSequence =
                new LongestConsecutiveSequence();

            int result = longestConsecutiveSequence.LongestConsecutive(nums);
        }
    }
}
