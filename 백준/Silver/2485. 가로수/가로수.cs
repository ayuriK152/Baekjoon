using System;

namespace AlgorithmStudy
{
    class boj2485
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] pos = new int[n];
            int[] len = new int[n - 1];

            pos[0] = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                pos[i] = int.Parse(Console.ReadLine());
                len[i - 1] = pos[i] - pos[i - 1];
            }

            for (int i = 0; i < n - 2; i++)
                len[i + 1] = Euclid(len[i], len[i + 1]);

            Console.WriteLine((pos[n - 1] - pos[0]) / len[n - 2] - n + 1);

            int Euclid(int a, int b)
            {
                if (b % a == 0)
                    return a;
                if (a > b)
                    return Euclid(a - b, b);
                else
                    return Euclid(b - a, a);
            }
        }
    }
}
