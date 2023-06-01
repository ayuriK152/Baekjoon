using System;

namespace AlgorithmStudy
{
    class boj20003
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numerator = new long[n];
            long[] denominator = new long[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                numerator[i] = long.Parse(input[0]);
                denominator[i] = long.Parse(input[1]);
            }

            if (n == 1)
            {
                long euclidNum = Euclid(numerator[0], denominator[0]);
                Console.WriteLine(numerator[0] / euclidNum + " " + denominator[0] / euclidNum);
            }
            else
            {
                long temp = denominator[0];
                long euclidNum;
                for (int i = 1; i < n; i++)
                {
                    euclidNum = Euclid(temp, denominator[i]);
                    temp = (temp * denominator[i]) / euclidNum;
                }
                for (int i = 0; i < n; i++)
                    numerator[i] *= temp / denominator[i];

                for (int i = 1; i < n; i++)
                {
                    numerator[0] = Euclid(numerator[0], numerator[i]);
                }

                euclidNum = Euclid(numerator[0], temp);
                Console.WriteLine(numerator[0] / euclidNum + " " + temp / euclidNum);
            }

            long Euclid(long a, long b)
            {
                if (b % a == 0)
                    return a;
                else
                    return Euclid(b % a, a);
            }
        }
    }
}
