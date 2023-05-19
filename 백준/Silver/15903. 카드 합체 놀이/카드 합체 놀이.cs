using System;

namespace AlgorithmStudy
{
    class boj15903
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            long[] arr = new long[n];
            input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
                arr[i] = long.Parse(input[i]);
            for (int i = 0; i < m; i++)
            {
                Array.Sort(arr);
                arr[0] += arr[1];
                arr[1] = arr[0];
            }
            long total = 0;
            foreach (long i in arr)
                total += i;
            Console.WriteLine(total);
        }
    }
}
