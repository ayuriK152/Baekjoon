using System;

namespace AlgorithmStudy
{
    internal class boj16937
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int h = int.Parse(input[0]), w = int.Parse(input[1]);
            int n = int.Parse(Console.ReadLine());
            int[,] length = new int[n, 2];

            int max = 0;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                length[i, 0] = int.Parse(input[0]);
                length[i, 1] = int.Parse(input[1]);
                int baseSize = length[i, 0] * length[i, 1];
                for (int j = 0; j < i; j++)
                {
                    int size = length[j, 0] * length[j, 1] + baseSize;
                    if ((length[i, 0] + length[j, 0] <= h && (length[i, 1] > length[j, 1] ? length[i, 1] : length[j, 1]) <= w) ||
                        (length[i, 0] + length[j, 1] <= h && (length[i, 1] > length[j, 0] ? length[i, 1] : length[j, 0]) <= w) ||
                        (length[i, 1] + length[j, 0] <= h && (length[i, 0] > length[j, 1] ? length[i, 0] : length[j, 1]) <= w) ||
                        (length[i, 1] + length[j, 1] <= h && (length[i, 0] > length[j, 0] ? length[i, 0] : length[j, 0]) <= w) ||
                        (length[i, 0] + length[j, 0] <= w && (length[i, 1] > length[j, 1] ? length[i, 1] : length[j, 1]) <= h) ||
                        (length[i, 0] + length[j, 1] <= w && (length[i, 1] > length[j, 0] ? length[i, 1] : length[j, 0]) <= h) ||
                        (length[i, 1] + length[j, 0] <= w && (length[i, 0] > length[j, 1] ? length[i, 0] : length[j, 1]) <= h) ||
                        (length[i, 1] + length[j, 1] <= w && (length[i, 0] > length[j, 0] ? length[i, 0] : length[j, 0]) <= h))
                        max = max < size ? size : max;
                }
            }

            Console.Write(max);
        }
    }
}
