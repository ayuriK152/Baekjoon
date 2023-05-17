using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj11508
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(sr.ReadLine());
            int[] items = new int[n];
            for (int i = 0; i < n; i++)
                items[i] = int.Parse(sr.ReadLine());
            Array.Sort(items);
            Array.Reverse(items);
            int total = 0;
            for (int i = 2; i < n; i += 3)
                total += items[i - 2] + items[i - 1];
            if (n % 3 == 1)
                total += items[n - 1];
            else if (n % 3 == 2)
                total += items[n - 1] + items[n - 2];
            sr.Close();
            Console.WriteLine(total);
        }
    }
}
