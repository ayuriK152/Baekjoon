using System;

namespace AlgorithmStudy
{
    class boj2847
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int total = 0;

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            for (int i = n - 1; i > 0; i--)
            {
                if (arr[i] <= arr[i - 1])
                {
                    total += arr[i - 1] - arr[i] + 1;
                    arr[i - 1] = arr[i] - 1;
                }
            }

            Console.WriteLine(total);
        }
    }
}
