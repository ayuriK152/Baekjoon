using System;
using System.Linq;

namespace AlgorithmStudy
{
    class boj2562
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[9];
            for (int i = 0; i < 9; i++)
                nums[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(nums.Max());
            Console.WriteLine(Array.IndexOf(nums, nums.Max()) + 1);
        }
    }
}