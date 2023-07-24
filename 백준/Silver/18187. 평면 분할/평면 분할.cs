using System;

namespace AlgorithmStudy
{
    class boj18187
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                count += 1 + i - i / 3;
            }
            Console.WriteLine(count);
        }
    }
}
