using System;

namespace AlgorithmStudy
{
    class boj2217
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] lopes = new int[n];
            for (int i = 0; i < n; i++)
                lopes[i] = int.Parse(Console.ReadLine());
            Array.Sort(lopes);
            int max = lopes[0] * n;
            for (int i = 1; i < n; i++)
            {
                if (max < lopes[i] * (n - i))
                    max = lopes[i] * (n - i);
            }
            Console.WriteLine(max);
        }
    }
}
