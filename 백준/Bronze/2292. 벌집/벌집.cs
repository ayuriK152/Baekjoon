using System;

namespace AlgorithmStudy
{
    class boj2292
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 1;
            for (int i = 0; ; i++)
            {
                if (n <= max)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
                max += 6 * (i + 1);
            }
        }
    }
}