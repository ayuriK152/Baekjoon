using System;

namespace AlgorithmStudy
{
    internal class boj11662
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Pair[] points = new Pair[4];
            points[0] = new Pair(int.Parse(input[0]), int.Parse(input[1]));
            points[1] = new Pair(int.Parse(input[2]), int.Parse(input[3]));
            points[2] = new Pair(int.Parse(input[4]), int.Parse(input[5]));
            points[3] = new Pair(int.Parse(input[6]), int.Parse(input[7]));

            Console.WriteLine("{0:F10}", TenarySearch(points[0], points[1], points[2], points[3]));


            double TenarySearch(Pair leftInit, Pair rightInit, Pair leftDest, Pair rightDest)
            {
                Pair midInitL = new Pair((leftInit.x * 2 + rightInit.x) / 3, (leftInit.y * 2 + rightInit.y) / 3);
                Pair midDestL = new Pair((leftDest.x * 2 + rightDest.x) / 3, (leftDest.y * 2 + rightDest.y) / 3);
                Pair midInitR = new Pair((leftInit.x + rightInit.x * 2) / 3, (leftInit.y + rightInit.y * 2) / 3);
                Pair midDestR = new Pair((leftDest.x + rightDest.x * 2) / 3, (leftDest.y + rightDest.y * 2) / 3);
                double midL = Math.Sqrt(Math.Pow((midDestL.x - midInitL.x), 2) + Math.Pow((midDestL.y - midInitL.y), 2));
                double midR = Math.Sqrt(Math.Pow((midDestR.x - midInitR.x), 2) + Math.Pow((midDestR.y - midInitR.y), 2));
                if (Math.Abs(leftInit.x - rightInit.x) < 0.000001 && Math.Abs(leftInit.x - rightInit.x) < 0.000001)
                    return midL;
                if (midL >= midR)
                {
                    leftInit = midInitL;
                    leftDest = midDestL;
                }
                else if (midR > midL)
                {
                    rightInit = midInitR;
                    rightDest = midDestR;
                }
                return TenarySearch(leftInit, rightInit, leftDest, rightDest);
            }
        }

        class Pair
        {
            public double x, y;

            public Pair(double _x, double _y)
            {
                x = _x;
                y = _y;
            }
        }
    }
}
