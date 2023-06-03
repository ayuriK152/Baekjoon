using System;

namespace AlgorithmStudy
{
    class boj2527
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                string[] input = Console.ReadLine().Split();
                int x1 = int.Parse(input[0]), y1 = int.Parse(input[1]), p1 = int.Parse(input[2]), q1 = int.Parse(input[3]);
                int x2 = int.Parse(input[4]), y2 = int.Parse(input[5]), p2 = int.Parse(input[6]), q2 = int.Parse(input[7]);

                bool isA = false;
                if ((x2 > x1 && x2 < p1 && ((y2 > y1 && y2 < q1) || (q2 > y1 && q2 < q1))) || (x1 > x2 && x1 < p2 && ((y1 > y2 && y1 < q2) || (q1 > y2 && q1 < q2))) ||
                    (p2 > x1 && p2 < p1 && ((y2 > y1 && y2 < q1) || (q2 > y1 && q2 < q1))) || (p1 > x2 && p1 < p2 && ((y1 > y2 && y1 < q2) || (q1 > y2 && q1 < q2))))
                    isA = true;

                if (!isA)
                    if ((x1 >= x2 && p1 <= p2 && y1 >= y2 && q1 <= q2) ||
                        (x2 >= x1 && p2 <= p1 && y2 >= y1 && q2 <= q1))
                        isA = true;

                if (!isA)
                {
                    if (x2 > x1)
                    {
                        if (x2 >= x1 && x2 < p1 && p2 > x1 && p2 <= p1 && y2 <= y1 && q2 >= q1)
                            isA = true;
                    }
                    else
                    {
                        if (x2 <= x1 && p2 >= p1 && y2 >= y1 && y2 < q1 && q2 > y1 && q2 <= q1)
                            isA = true;
                    }
                }

                if (isA)
                {
                    Console.WriteLine("a");
                    continue;
                }

                if ((((x1 <= x2 && p1 >= p2) || (x1 > x2 && x1 < p2) || (p1 > x2 && p1 < p2)) && (y1 == q2 || q1 == y2)) ||
                    (((y1 <= y2 && q1 >= q2) || (y1 > y2 && y1 < q2) || (q1 > y2 && q1 < q2)) && (x1 == p2 || p1 == x2)))
                {
                    Console.WriteLine("b");
                    continue;
                }

                if ((x1 == p2 && (y1 == q2 || q1 == y2)) || (p1 == x2 && (y1 == q2 || q1 == y2)))
                {
                    Console.WriteLine("c");
                    continue;
                }

                Console.WriteLine("d");
            }
        }
    }
}
