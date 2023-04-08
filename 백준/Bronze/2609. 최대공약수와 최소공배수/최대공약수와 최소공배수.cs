using System;

namespace AlgorithmStudy
{
    class boj2609
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int a = int.Parse(temp[0]), b = int.Parse(temp[1]);
            int gcd = GCD(Math.Max(a, b), Math.Min(a, b));
            int lcm = (a * b) / gcd;
            Console.WriteLine(gcd);
            Console.WriteLine(lcm);
        }
        static int GCD(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return GCD(b, a % b);
        }
    }
}