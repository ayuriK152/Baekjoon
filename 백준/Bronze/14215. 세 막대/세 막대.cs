using System;

namespace AlgorithmStudy
{
    internal class boj14215
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);
            int max = a > b ? a : b;
            max = c > max ? c : max;
            int length = 0;
            length += a + b + c - max <= max ? a + b + c - max - 1 : max;
            length += a + b + c - max;
            Console.Write(length);
        }
    }
}
