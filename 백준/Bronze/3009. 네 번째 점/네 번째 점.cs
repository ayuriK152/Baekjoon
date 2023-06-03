using System;

namespace AlgorithmStudy
{
    class boj3009
    {
        public static void Main(string[] args)
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            int[] counts = new int[4];
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]), b = int.Parse(input[1]);
                if (x1 == 0 || x1 == a)
                {
                    x1 = a;
                    counts[0]++;
                }
                else if (x1 > a)
                {
                    x2 = x1;
                    x1 = a;
                    int temp = counts[2];
                    counts[2] = counts[0];
                    counts[0] = temp + 1;
                }
                else
                {
                    x2 = a;
                    counts[2]++;
                }
                if (y1 == 0 || y1 == b)
                {
                    y1 = b;
                    counts[1]++;
                }
                else if (y1 > b)
                {
                    y2 = y1;
                    y1 = b;
                    int temp = counts[3];
                    counts[3] = counts[1];
                    counts[1] = temp + 1;
                }
                else
                {
                    y2 = b;
                    counts[3]++;
                }
            }

            if (counts[0] == 1)
                Console.Write(x1);
            else
                Console.Write(x2);
            if (counts[1] == 1)
                Console.Write(" " + y1);
            else
                Console.Write(" " + y2);
        }
    }
}
