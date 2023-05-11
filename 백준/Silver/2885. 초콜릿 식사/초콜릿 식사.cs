using System;

namespace AlgorithmStudy
{
    class boj2885
    {
        public static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = 1;
            int min = -1;
            while (k > n)
            {
                if (min == -1 && (n & k) != 0)
                    min = n;
                n = n << 1;
            }
            if (min == -1)
                min = n;
            Console.WriteLine(n + " " + (Math.Log(n, 2) - Math.Log(min, 2)));
        }
    }
}
