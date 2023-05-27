using System;

namespace AlgorithmStudy
{
    class boj16931
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(input[j]);
                }
            }

            int total = 2 * n * m;
            for (int i = 0; i < n; i++)
            {
                total += arr[i, 0];
                total += arr[i, m - 1];
            }
            for (int i = 0; i < m; i++)
            {
                total += arr[0, i];
                total += arr[n - 1, i];
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < m - 1)
                        if (arr[j, i] < arr[j, i + 1])
                            total += arr[j, i + 1] - arr[j, i];
                    if (i > 0)
                        if (arr[j, i] < arr[j, i - 1])
                            total += arr[j, i - 1] - arr[j, i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i < n - 1)
                        if (arr[i, j] < arr[i + 1, j])
                            total += arr[i + 1, j] - arr[i, j];
                    if (i > 0)
                        if (arr[i, j] < arr[i - 1, j])
                            total += arr[i - 1, j] - arr[i, j];
                }
            }
            Console.WriteLine(total);
        }
    }
}
