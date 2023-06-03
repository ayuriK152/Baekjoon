using System;

namespace AlgorithmStudy
{
    class boj17386
    {
        public static void Main(string[] args)
        {
            int[] x = new int[4];
            int[] y = new int[4];
            string[] input = Console.ReadLine().Split();
            x[0] = int.Parse(input[0]); x[1] = int.Parse(input[2]);
            y[0] = int.Parse(input[1]); y[1] = int.Parse(input[3]);
            input = Console.ReadLine().Split();
            x[2] = int.Parse(input[0]); x[3] = int.Parse(input[2]);
            y[2] = int.Parse(input[1]); y[3] = int.Parse(input[3]);
            int[,] vectors = new int[2, 6];
            vectors[0, 0] = x[1] - x[0]; vectors[1, 0] = y[1] - y[0];
            vectors[0, 1] = x[2] - x[1]; vectors[1, 1] = y[2] - y[1];
            vectors[0, 2] = x[3] - x[1]; vectors[1, 2] = y[3] - y[1];
            vectors[0, 3] = x[3] - x[2]; vectors[1, 3] = y[3] - y[2];
            vectors[0, 4] = x[0] - x[3]; vectors[1, 4] = y[0] - y[3];
            vectors[0, 5] = x[1] - x[3]; vectors[1, 5] = y[1] - y[3];

            long[] ccw = new long[2];
            ccw[0] = CCW(vectors[0, 0], vectors[1, 0], vectors[0, 1], vectors[1, 1]);
            ccw[1] = CCW(vectors[0, 0], vectors[1, 0], vectors[0, 2], vectors[1, 2]);
            if ((ccw[0] > 0 && ccw[1] < 0) || (ccw[0] < 0 && ccw[1] > 0))
            {
                ccw[0] = CCW(vectors[0, 3], vectors[1, 3], vectors[0, 4], vectors[1, 4]);
                ccw[1] = CCW(vectors[0, 3], vectors[1, 3], vectors[0, 5], vectors[1, 5]);
                if ((ccw[0] > 0 && ccw[1] < 0) || (ccw[0] < 0 && ccw[1] > 0))
                    Console.WriteLine("1");
                else
                    Console.WriteLine("0");
            }
            else
                Console.WriteLine("0");

            long CCW(long x1, long y1, long x2, long y2)
            {
                return x1 * y2 - (x2 * y1);
            }
        }
    }
}
