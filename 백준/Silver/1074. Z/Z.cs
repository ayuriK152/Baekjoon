using System;

namespace AlgorithmStudy
{
    class boj1074
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int n = int.Parse(temp[0]), r = int.Parse(temp[1]), c = int.Parse(temp[2]);

            Console.WriteLine(VisitCount(0, (int)Math.Pow(2, n) - 1, 0, (int)Math.Pow(2, n) - 1, n));

            int VisitCount(int minX, int maxX, int minY, int maxY, int pow)
            {
                int count = 0;
                int partition;
                if (minX == maxX)
                    return 0;
                if (minX - maxX == 1)
                    partition = 1;
                else
                    partition = (int)(Math.Pow(Math.Pow(2, pow - 1), 2));

                int midX = (minX + maxX) / 2;
                int midY = (minY + maxY) / 2;
                if (c <= midX && r <= midY)
                {
                    count += VisitCount(minX, midX, minY, midY, pow - 1);
                }
                else if(c > midX && r <= midY)
                {
                    count += partition;
                    count += VisitCount(midX + 1, maxX, minY, midY, pow - 1);
                }
                else if (c <= midX && r > midY)
                {
                    count += partition * 2;
                    count += VisitCount(minX, midX, midY + 1, maxY, pow - 1);
                }
                else if (c > midX && r > midY)
                {
                    count += partition * 3;
                    count += VisitCount(midX + 1, maxX, midY + 1, maxY, pow - 1);
                }

                return count;
            }
        }
    }
}