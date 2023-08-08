using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj15565
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), k = int.Parse(input[1]);
            List<int> ryanIndex = new List<int>();
            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                if (input[i] == "1")
                    ryanIndex.Add(i);

            int result = -1;
            if (ryanIndex.Count >= k)
                for (int i = 0; i + k - 1 < ryanIndex.Count; i++)
                    if (ryanIndex[i + k - 1] - ryanIndex[i] + 1 < result || result == -1)
                        result = ryanIndex[i + k - 1] - ryanIndex[i] + 1;

            Console.WriteLine(result);
        }
    }
}
