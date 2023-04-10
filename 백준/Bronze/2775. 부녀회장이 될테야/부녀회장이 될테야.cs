using System;

namespace AlgorithmStudy
{
    class boj2775
    {
        public static void Main(string[] args)
        {
            int[,] dp = new int[15, 14];
            for (int i = 0; i < 14; i++)
                dp[0, i] = i + 1;
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(Sum(k, n - 1));
            }

            int Sum(int a, int b)
            {
                if (dp[a, b] != 0)
                    return dp[a, b];
                if (b == 0)
                    return 1;
                dp[a, b] = Sum(a - 1, b) + Sum(a, b - 1);
                return dp[a, b];
            }
        }
    }
}
