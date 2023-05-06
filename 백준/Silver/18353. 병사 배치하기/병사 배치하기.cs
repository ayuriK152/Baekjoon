using System;

namespace AlgorithmStudy
{
    class boj18353
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] soldier = new int[n];
            int[] dp = new int[n];

            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
                soldier[i] = int.Parse(input[i]);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < i; j++)
                    if (soldier[j] > soldier[i])
                        dp[i] = dp[i] > dp[j] + 1 ? dp[i] : dp[j] + 1;

            int max = 0;
            foreach (int i in dp)
                max = i > max ? i : max;
            Console.WriteLine(n - (max + 1));
        }
    }
}
