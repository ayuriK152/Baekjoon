using System;

namespace AlgorithmStudy
{
    class boj12865
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), k = int.Parse(input[1]);
            int[] weights = new int[n + 1];
            int[] values = new int[n + 1];
            int[,] dp = new int[n + 1, k + 1];

            for (int i = 1; i <= n; i++)
            {
                input = Console.ReadLine().Split();
                weights[i] = int.Parse(input[0]);
                values[i] = int.Parse(input[1]);
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    if (weights[i] <= j)
                    {
                        if (j - weights[i] > 0)
                            dp[i, j] = dp[i - 1, j - weights[i]] + values[i] > dp[i - 1, j] ? dp[i - 1, j - weights[i]] + values[i] : dp[i - 1, j];
                        else
                            dp[i, j] = values[i] > dp[i - 1, j] ? values[i] : dp[i - 1, j];
                    }
                    else
                        dp[i, j] = dp[i - 1, j];
                }
            }

            Console.WriteLine(dp[n, k]);
        }
    }
}
