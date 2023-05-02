using System;
using System.Linq;

namespace AlgorithmStudy
{
    class boj14501
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] time = new int[n];
            int[] pay = new int[n];
            int[] dp = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                time[i] = int.Parse(input[0]);
                pay[i] = int.Parse(input[1]);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (i + time[i] > n)
                    continue;

                if (i + time[i] == n)
                {
                    dp[i] += pay[i];
                    continue;
                }

                dp[i] += pay[i];
                int max = 0;
                for (int j = i + time[i]; j < n; j++)
                    if (dp[j] > max)
                        max = dp[j];
                dp[i] += max;
            }
            Console.WriteLine(dp.Max());
        }
    }
}
