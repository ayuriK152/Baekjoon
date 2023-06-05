using System;

namespace AlgorithmStudy
{
    class boj1064
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int x1 = int.Parse(input[0]), y1 = int.Parse(input[1]), x2 = int.Parse(input[2]), y2 = int.Parse(input[3]), x3 = int.Parse(input[4]), y3 = int.Parse(input[5]);
            double result = 0;
            if ((x2 - x1) * (y3 - y2) - (x3 - x2) * (y2 - y1) == 0)
                result = -1;
            else
            {
                double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

                result = Math.Max(Math.Max(a + b, b + c), a + c) - Math.Min(Math.Min(a + b, b + c), a + c);
                result *= 2;
            }
            if (result == (int)result)
                Console.WriteLine(result + ".0");
            else
                Console.WriteLine(result);
        }
    }
}
