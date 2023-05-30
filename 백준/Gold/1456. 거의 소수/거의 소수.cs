using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj1456
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long a = long.Parse(input[0]), b = long.Parse(input[1]);
            bool[] primeCheck = new bool[(int)Math.Sqrt(b)];
            List<long> primeNums = new List<long>();

            for (int i = 1; i < primeCheck.Length; i++)
            {
                if (!primeCheck[i])
                {
                    primeNums.Add(i + 1);
                    for (int j = i + 1; j <= primeCheck.Length; j += i + 1)
                    {
                        primeCheck[j - 1] = true;
                    }
                }
            }

            long count = 0;
            for (int i = 0; i < primeNums.Count; i++)
            {
                double logA = Math.Log(a, primeNums[i]);
                double logB = Math.Log(b, primeNums[i]);
                if (logA == logB && Math.Pow(primeNums[i], (long)logA) == a)
                {
                    count = 1;
                    break;
                }
                count += (long)logB - (long)logA;
                if (logA < 1)
                    count--;
                if (logA >= 2 && Math.Pow(primeNums[i], (int)logA) == a)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
