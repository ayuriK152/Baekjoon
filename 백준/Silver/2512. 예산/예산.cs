using System;
using System.Linq;

namespace AlgorithmStudy
{
    class boj2512
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[n];
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(input[i]);
                total += nums[i];
            }
            int m = int.Parse(Console.ReadLine());
            if (total <= m)
                Console.WriteLine(nums.Max());
            else
                Console.WriteLine(ParametricSearch(1, nums.Max()));

            int ParametricSearch(int start, int end)
            {
                int mid = (start + end) / 2;
                bool isMoneyEnough = Calc(mid);
                if (!isMoneyEnough)
                    return ParametricSearch(start, mid);
                else if (isMoneyEnough && (start == mid || mid == end))
                {
                    if (Calc(end))
                        return end;
                    else
                        return start;
                }
                else
                    return ParametricSearch(mid, end);
            }

            bool Calc(int value)
            {
                int temp = 0;
                foreach (int i in nums)
                {
                    if (i > value)
                        temp += value;
                    else
                        temp += i;
                }
                if (temp <= m)
                    return true;
                else
                    return false;
            }
        }
    }
}
