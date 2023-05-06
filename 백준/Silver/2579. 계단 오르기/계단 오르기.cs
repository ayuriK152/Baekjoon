using System;

namespace AlgorithmStudy
{
    class boj2579
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] stairs = new int[n + 1];
            int[] dp = new int[n + 1];
            for (int i = 1; i <= n; i++)
                stairs[i] = int.Parse(Console.ReadLine());
            dp[1] = stairs[1];
            if (n >= 2)
                dp[2] = stairs[1] + stairs[2];
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 2] > dp[i - 3] + stairs[i - 1] ? dp[i - 2] : dp[i - 3] + stairs[i - 1];                                                                          // i번째의 계단을 밟으면 안되는 경우는 i번째 연산에서 고려하지 않음.
                dp[i] += stairs[i];
            }
            Console.WriteLine(dp[n]);
        }
    }
}
