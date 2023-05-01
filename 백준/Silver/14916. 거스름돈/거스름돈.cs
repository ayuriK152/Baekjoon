using System;

namespace AlgorithmStudy
{
    class boj14916
    {
        public static void Main(string[] args)
        {
            int[] dp = new int[100001];
            dp[1] = -1;
            dp[3] = -1;
            int count = 1;
            int n = int.Parse(Console.ReadLine());
            bool isFound = false;
            for (int i = 1; ; i++)
            {
                if (dp[n] != 0)
                    break;
                if (dp[i] != 0)
                    continue;
                else
                {
                    for (int j = 0; j <= count && j < 5; j++)
                    {
                        if (i + (3 * j) > 100000)
                            break;
                        dp[i + (3 * j)] = count;
                    }
                }
                count++;
            }
            Console.WriteLine(dp[n]);
        }
    }
}
