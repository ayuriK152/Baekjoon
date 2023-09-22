using System;

namespace AlgorithmStudy
{
    internal class boj16486
    {
        public static void Main(string[] args)
        {
            const double PI = 3.141592;
            int d1 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());
            Console.Write("{0:F6}", (d1 * 2) + (2 * d2 * PI));
        }
    }
}
