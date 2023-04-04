using System;

namespace AlgorithmStudy
{
    class boj17608
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sticks = new int[n];
            for (int i = 0; i < n; i++)
                sticks[i] = int.Parse(Console.ReadLine());

            int max = 0, count = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (sticks[i] > max)
                {
                    max = sticks[i];
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}