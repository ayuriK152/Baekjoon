using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj11047
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            string[] input = sr.ReadLine().Split();
            int n = int.Parse(input[0]), k = int.Parse(input[1]);
            int[] coins = new int[n];
            for (int i = 0; i < n; i++)
                coins[i] = int.Parse(sr.ReadLine());
            sr.Close();
            int count = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                while (k >= coins[i])
                {
                    k -= coins[i];
                    count++;
                }
                if (k == 0)
                    break;
            }
            Console.WriteLine(count);
        }
    }
}
