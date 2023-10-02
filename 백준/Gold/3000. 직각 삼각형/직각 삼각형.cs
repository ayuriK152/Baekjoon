using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj3000
    {
        public static void Main(string[] args)
        {
            Dictionary<int, int> dictX = new Dictionary<int, int>();
            Dictionary<int, int> dictY = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            KeyValuePair<int, int>[] dots = new KeyValuePair<int, int>[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                dots[i] = new KeyValuePair<int, int>(int.Parse(input[0]), int.Parse(input[1]));
                if (!dictX.ContainsKey(dots[i].Key))
                    dictX.Add(dots[i].Key, 0);
                if (!dictY.ContainsKey(dots[i].Value))
                    dictY.Add(dots[i].Value, 0);
                dictX[dots[i].Key]++;
                dictY[dots[i].Value]++;
            }

            long count = 0;
            for (int i = 0; i < n; i++)
                count += (long)(dictX[dots[i].Key] - 1) * (dictY[dots[i].Value] - 1);

            Console.Write(count);
        }
    }
}
