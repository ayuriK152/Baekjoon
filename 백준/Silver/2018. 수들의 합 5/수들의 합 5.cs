using System;

namespace AlgorithmStudy
{
    class boj2018
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 1; i <= n / 2; i++)
            {
                for (int j = i + 1; j <= n / 2 + 1; j++)
                {
                    int temp = (j + i) % 2 == 0 ? (j + i) * (j - (j + i) / 2) + (j + i) / 2 : (j + i) * (j - (j + i) / 2);
                    if (temp == n)
                    {
                        count++;
                        break;
                    }
                    else if (temp > n)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
