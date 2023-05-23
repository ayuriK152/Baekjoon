using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj1427
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string input = Console.ReadLine();
            short[] nums = new short[input.Length];
            for (int i = 0; i < nums.Length; i++)
                nums[i] = short.Parse(input[i].ToString());
            Array.Sort(nums);
            for (int i = nums.Length - 1; i >= 0; i--)
                sb.Append(nums[i]);
            Console.WriteLine(sb);
        }
    }
}
