using System;

namespace AlgorithmStudy
{
    class boj2908
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int tempA = int.Parse(temp[0]);
            int tempB = int.Parse(temp[1]);
            int a = 0, b = 0;
            a += tempA / 100; tempA -= tempA / 100 * 100;
            a += tempA / 10 * 10; tempA -= tempA / 10 * 10;
            a += tempA / 1 * 100;
            b += tempB / 100; tempB -= tempB / 100 * 100;
            b += tempB / 10 * 10; tempB -= tempB / 10 * 10;
            b += tempB / 1 * 100;
            Console.WriteLine(Math.Max(a, b));
        }
    }
}