using System;

namespace AlgorithmStudy
{
    class boj2477
    {
        public static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int h = 0, w = 0;
            int[,] path = new int[2, 7];
            for (int i = 0; i < 6; i++)
            {
                string[] input = Console.ReadLine().Split();
                path[0, i] = int.Parse(input[0]);
                path[1, i] = int.Parse(input[1]);
            }
            path[0, 6] = path[0, 0];
            path[1, 6] = path[1, 0];

            int total = 0;
            for (int i = 0; i < 6; i++)
            {
                if ((path[0, i] == 1 && path[0, i + 1] == 4) ||
                    (path[0, i] == 4 && path[0, i + 1] == 2) ||
                    (path[0, i] == 2 && path[0, i + 1] == 3) ||
                    (path[0, i] == 3 && path[0, i + 1] == 1))
                {
                    if ((path[0, i] == 1 || path[0, i] == 2) && w < path[1, i])
                        w = path[1, i];
                    else if ((path[0, i] == 3 || path[0, i] == 4) && h < path[1, i])
                        h = path[1, i];
                }
                else
                    total -= path[1, i] * path[1, i + 1];
            }
            total += w * h;
            total *= k;
            Console.WriteLine(total);
        }
    }
}
