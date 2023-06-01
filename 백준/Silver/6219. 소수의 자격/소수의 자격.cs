using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj6219
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]), b = int.Parse(input[1]), d = int.Parse(input[2]);
            bool[] primeCheck = new bool[b];
            List<int> primeNums = new List<int>();

            for (int i = 1; i < b; i++)
            {
                if (!primeCheck[i])
                {
                    primeCheck[i] = true;
                    if (i + 1 >= a)
                        primeNums.Add(i + 1);
                    for (int j = i + 1; j <= b; j += i + 1)
                    {
                        primeCheck[j - 1] = true;
                    }
                }
            }

            int count = 0;
            foreach (int i in primeNums)
            {
                int temp = i;
                while (temp != 0)
                {
                    if (temp % 10 == d)
                    {
                        count++;
                        break;
                    }
                    temp = (int)(temp / 10.0f);
                }
            }

            Console.WriteLine(count);
        }
    }
}
