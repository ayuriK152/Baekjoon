using System;

namespace AlgorithmStudy
{
    class boj3040
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[9];
            int total = 0;
            for (int i = 0; i < 9; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                total += nums[i];
            }
            total -= 100;
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    if (nums[i] + nums[j] == total)
                    {
                        nums[i] = 0;
                        nums[j] = 0;
                        break;
                    }
                }
                if (nums[i] == 0)
                    break;
            }
            for (int i = 0; i < 9; i++)
            {
                if (nums[i] != 0)
                    Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}