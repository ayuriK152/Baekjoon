using System;

namespace AlgorithmStudy
{
    class boj25344
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            long period = long.Parse(input[0]);
            for (int i = 1; i < n - 2; i++)
            {
                long secPeriod = long.Parse(input[i]);
                long euclidNum = Euclid(period, secPeriod);
                period = (period * secPeriod) / euclidNum;
            }

            Console.WriteLine(period);

            long Euclid(long a, long b)
            {
                if (b % a == 0)
                    return a;
                return Euclid(b % a, a);
            }
        }
    }
}
