using System;

namespace AlgorithmStudy
{
    class boj2748
    {
        public static void Main(string[] args)
        {
            long[] fib = new long[91];
            fib[0] = 0;
            fib[1] = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            Console.WriteLine(fib[n]);
        }
    }
}
