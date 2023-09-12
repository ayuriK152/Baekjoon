using System;

namespace AlgorithmStudy
{
    internal class boj2022
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double x = double.Parse(input[0]), y = double.Parse(input[1]), c = double.Parse(input[2]);
            Console.WriteLine("{0:F3}", BinarySearch(0, x > y ? y : x));

            double BinarySearch(double min, double max)
            {
                double mid = (min + max) / 2;
                double h_x = Math.Sqrt(x * x - mid * mid);
                double h_y = Math.Sqrt(y * y - mid * mid);
                double cTemp = Math.Round((((h_x * h_y) / (h_x + h_y)) * 1000000)) / 1000000;
                if (cTemp == c)
                    return Math.Round(mid * 1000) / 1000;
                else if (cTemp > c)
                    return BinarySearch(mid, max);
                else
                    return BinarySearch(min, mid);
            }
        }
    }
}
