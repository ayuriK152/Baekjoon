using System;

namespace AlgorithmStudy
{
    class boj2869
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]), b = int.Parse(input[1]), v = int.Parse(input[2]);
            v -= a;
            int count = 1;
            if (v > 0)
            {
                double tempD = v / (double)(a - b);
                int tempI = v / (a - b);
                if (tempD == (double)tempI)
                    count += v / (a - b);
                else
                    count += v / (a - b) + 1;
            }
            Console.WriteLine(count);
        }
    }
}