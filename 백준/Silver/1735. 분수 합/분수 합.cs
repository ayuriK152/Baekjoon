using System;

namespace AlgorithmStudy
{
    class boj1735
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numA = new int[2];
            numA[0] = int.Parse(input[0]); numA[1] = int.Parse(input[1]);
            input = Console.ReadLine().Split();
            int[] numB = new int[2];
            numB[0] = int.Parse(input[0]); numB[1] = int.Parse(input[1]);

            int[] result = new int[2];
            result[0] = numA[0] * numB[1] + numB[0] * numA[1];
            result[1] = numA[1] * numB[1];

            int divisor = Euclid(result[0], result[1]);
            result[0] /= divisor;
            result[1] /= divisor;
            Console.WriteLine(result[0] + " " + result[1]);

            int Euclid(int a, int b)
            {
                if (b % a == 0)
                    return a;
                else
                    return Euclid(b % a, a);
            }
        }
    }
}
