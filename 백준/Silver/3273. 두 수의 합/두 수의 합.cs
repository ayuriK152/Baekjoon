using System;

namespace AlgorithmStudy
{
    class boj3273
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
                nums[i] = int.Parse(input[i]);
            int x = int.Parse(Console.ReadLine());
            int count = 0;
            if (n > 1)
            {
                Array.Sort(nums);

                int pivotL = 0, pivotR = n - 1;
                while (pivotL < pivotR)
                {
                    if (nums[pivotL] + nums[pivotR] == x)
                        count++;
                    if (nums[pivotL] + nums[pivotR] >= x)
                        pivotR--;
                    else
                        pivotL++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
