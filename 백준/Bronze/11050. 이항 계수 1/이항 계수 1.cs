using System;

namespace AlgorithmStudy
{
    class boj11050
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), k = int.Parse(input[1]);
            int result = Factorial(n) / (Factorial(k) * Factorial(n - k));
            Console.WriteLine(result);

            int Factorial(int a)
            {
                if (a <= 1)
                    return 1;
                else
                    return a * Factorial(a - 1);
            }
        }
    }
}