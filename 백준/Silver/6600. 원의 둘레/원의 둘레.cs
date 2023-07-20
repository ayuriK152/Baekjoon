using System;

namespace AlgorithmStudy
{
    class boj6600
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null) break;
                string[] positions = input.Split(' ');
                double x1 = double.Parse(positions[0]), y1 = double.Parse(positions[1]),
                    x2 = double.Parse(positions[2]), y2 = double.Parse(positions[3]),
                    x3 = double.Parse(positions[4]), y3 = double.Parse(positions[5]);
                double p, q;
                double a1 = -(x1 - x2) / (y1 - y2), a2 = -(x2 - x3) / (y2 - y3);
                double c1 = a1 * ((x1 + x2) / 2) - (y1 + y2) / 2, c2 = a2 * ((x2 + x3) / 2) - (y2 + y3) / 2;
                if (y1 - y2 == 0) { p = (x1 + x2) / 2; a1 = a2; c1 = c2; }
                else if (y2 - y3 == 0) { p = (x2 + x3) / 2; a2 = a1; c2 = c1; }
                else p = (c1 - c2) / (a1 - a2);
                if (x1 - x2 == 0) q = (y1 + y2) / 2;
                else if (x2 - x3 == 0) q = (y2 + y3) / 2;
                else q = a1 * p - c1;
                double r = Math.Sqrt(Math.Pow(p - x1, 2) + Math.Pow(q - y1, 2));
                double result =  Math.PI * r * 2;
                Console.WriteLine(Math.Round(result, 2));
            }
        }
    }
}
