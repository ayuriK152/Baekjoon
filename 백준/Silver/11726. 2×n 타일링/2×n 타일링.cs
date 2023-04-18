using System;

namespace AlgorithmStudy
{
    class boj11726
    {
        public static void Main(string[] args)
        {
            int[] dp = new int[1001];
            dp[1] = 1;
            dp[2] = 2;
            int n = int.Parse(Console.ReadLine());
            for (int i = 3; i <= n; i++)
                dp[i] = (dp[i - 1] + dp[i - 2]) % 10007;
            Console.WriteLine(dp[n]);
        }
    }
}
