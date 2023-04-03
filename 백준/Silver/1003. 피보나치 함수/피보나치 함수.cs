using System;

namespace AlgorithmStudy
{
    class boj1003
    {
        public static void Main(string[] args)
        {
            int[] dpZero = new int[41];
            int[] dpOne = new int[41];
            bool[] dp = new bool[41];
            dpZero[0] = dpOne[1] = 1;
            dpZero[1] = dpOne[0] = 0;
            dp[0] = dp[1] = true;

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                fib(temp);
                Console.WriteLine(dpZero[temp] + " " + dpOne[temp]);
            }

            void fib(int n)
            {
                if (n < 2 || dp[n])
                    return;
                if (!dp[n - 1] && dp[n - 2])
                {
                    fib(n - 1);
                }
                else if (!dp[n - 1] && !dp[n - 2])
                {
                    fib(n - 2);
                    fib(n - 1);
                }
                dpZero[n] += dpZero[n - 1];
                dpOne[n] += dpOne[n - 1];
                dpZero[n] += dpZero[n - 2];
                dpOne[n] += dpOne[n - 2];
                dp[n] = true;
            }
        }
    }
}