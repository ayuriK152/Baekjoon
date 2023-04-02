using System;
using System.Resources;
using System.Text;

namespace AlgorithmStudy
{
    class boj1929
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int m = int.Parse(temp[0]), n = int.Parse(temp[1]);
            bool[] isPrime = new bool[n];
            isPrime[0] = true;
            CheckPrime();
            StringBuilder result = new StringBuilder();
            for (int i = m - 1; i < n; i++)
                if (!isPrime[i])
                    result.AppendLine((i + 1).ToString());
            Console.WriteLine(result);
            void CheckPrime()
            {
                for (int i = 1; i < n; i++)
                    if (!isPrime[i])
                        for (int j = 2; j * (i + 1) <= n; j++)
                            isPrime[j * (i + 1) - 1] = true;
            }
        }
    }
}