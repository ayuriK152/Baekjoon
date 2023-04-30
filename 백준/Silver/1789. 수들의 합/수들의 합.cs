using System;

namespace AlgorithmStudy
{
    class boj1789
    {
        public static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            long total = 0;
            for (int i = 1; ; i++)
            {
                total += i;
                if (n < total)
                {
                    Console.WriteLine(i - 1);
                    break;
                }
            }
        }
    }
}
