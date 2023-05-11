using System;
using System.Linq;
using System.Text;

namespace AlgorithmStudy
{
    class boj2667
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string n = Console.ReadLine();
            int[] nums = new int[n.Length];
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(n[i].ToString());
                total += nums[i];
            }
            Array.Sort(nums);
            Array.Reverse(nums);
            if (total % 3 != 0 || nums[nums.Length - 1] != 0)
                Console.WriteLine("-1");
            else
            {
                foreach (int i in nums)
                    sb.Append(i);
                Console.WriteLine(sb);
            }
        }
    }
}
