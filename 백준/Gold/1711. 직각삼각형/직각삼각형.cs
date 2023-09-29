using System;

namespace AlgorithmStudy
{
    class boj1711
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Pos[] dots = new Pos[n];
            string[] input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                dots[i] = new Pos(long.Parse(input[0]), long.Parse(input[1]));
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        continue;
                    for (int k = j + 1; k < n; k++)
                    {
                        if (i == k)
                            continue;
                        long product = (dots[j].x - dots[i].x) * (dots[k].x - dots[i].x) + (dots[j].y - dots[i].y) * (dots[k].y - dots[i].y);
                        if (product == 0)
                            count++;
                    }
                }
            }

            Console.Write(count);
        }

        class Pos
        {
            public long x, y;

            public Pos(long _x, long _y)
            {
                x = _x;
                y = _y;
            }
        }
    }
}
