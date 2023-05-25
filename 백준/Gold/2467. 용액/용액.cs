using System;

namespace AlgorithmStudy
{
    class boj2467
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(input[i]);

            int diff = -1, bestL = -1, bestR = -1;
            for (int i = 0; i < n - 1; i++)
                ParametricSearch(i + 1, n - 1, i);

            Console.WriteLine(arr[bestL] + " " + arr[bestR]);

            void ParametricSearch(int pivotL, int pivotR, int idx)
            {
                int mid = (pivotL + pivotR) / 2;
                if (pivotL > pivotR || mid >= n)
                    return;
                int tempDiff = Math.Abs(arr[idx] + arr[mid]);
                if (tempDiff < diff || diff == -1)
                {
                    diff = tempDiff;
                    bestL = idx;
                    bestR = mid;
                }
                if (Math.Abs(arr[idx]) - Math.Abs(arr[mid]) < 0)
                    ParametricSearch(pivotL, mid - 1, idx);
                else
                    ParametricSearch(mid + 1, pivotR, idx);
            }
        }
    }
}
