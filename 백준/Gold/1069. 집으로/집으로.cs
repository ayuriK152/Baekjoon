using System;

namespace AlgorithmStudy
{
    internal class boj1069
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int x = int.Parse(input[0]), y = int.Parse(input[1]), d = int.Parse(input[2]), t = int.Parse(input[3]);
            double length = Math.Sqrt(x * x + y * y);
            double jumpCnt = (int)(length / d);

            double result = 0;
            double less = length + (t - d) * jumpCnt;
            double over = (d + t) * (jumpCnt + 1) - length;
            double fold = jumpCnt > 0 ? t * (jumpCnt + 1) : t * 2;
            result = length > over ? over : length;
            result = result > fold ? fold : result;
            result = result > less ? less : result;

            if ((int)result != result)
                Console.WriteLine(result);
            else
                Console.WriteLine("{0:F1}", result);
        }
    }
}
