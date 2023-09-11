using System;

namespace AlgorithmStudy
{
    internal class boj1027
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] builds = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                builds[i] = int.Parse(input[i]);

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                Pair origin = new Pair(i, builds[i]);
                Pair left = i > 0 ? new Pair(i - 1, builds[i - 1]) : null;
                Pair right = i < n - 1 ? new Pair(i + 1, builds[i + 1]) : null;

                if (left != null)
                    count++;
                if (right != null)
                    count++;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (CCW(origin, left, new Pair(j, builds[j])) < 0)
                    {
                        count++;
                        left.x = j;
                        left.y = builds[j];
                    }
                }

                for (int j = i + 1; j < n; j++)
                {
                    if (CCW(origin, right, new Pair(j, builds[j])) > 0)
                    {
                        count++;
                        right.x = j;
                        right.y = builds[j];
                    }
                }

                if (count > result)
                    result = count;
            }

            Console.WriteLine(result);

            long CCW(Pair _first, Pair _second, Pair _third)
            {
                return (_second.x - _first.x) * (_third.y - _second.y) - (_third.x - _second.x) * (_second.y - _first.y);
            }
        }

        class Pair
        {
            public long x, y;

            public Pair(long _x, long _y)
            {
                x = _x;
                y = _y;
            }
        }
    }
}
