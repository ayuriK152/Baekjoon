using System;

namespace AlgorithmStudy
{
    class boj1806
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), s = int.Parse(input[1]);
            int[] sums = new int[n + 1];
            input = Console.ReadLine().Split();
            sums[1] = int.Parse(input[0]);
            for (int i = 2; i <= n; i++)
                sums[i] = int.Parse(input[i - 1]) + sums[i - 1];

            int pivotL = 0, pivotR = 1, len = 0;
            while (pivotL != pivotR || pivotR != n)
            {
                int tempSum = sums[pivotR] - sums[pivotL];
                if (tempSum >= s && (pivotR - pivotL < len || len == 0))
                    len = pivotR - pivotL;
                if ((tempSum >= s && pivotL + 1 != pivotR) || pivotR == n)
                    pivotL++;
                else
                    pivotR++;
            }
            Console.WriteLine(len);
        }
    }
}
