using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj20157
    {
        public static void Main(string[] args)
        {
            Dictionary<double, int[]> unitVec = new Dictionary<double, int[]>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                long x = long.Parse(input[0]), y = long.Parse(input[1]);
                if (!unitVec.ContainsKey(y / (double)x))
                    unitVec.Add(y / (double)x, new int[2]);
                if (y >= 0)
                    unitVec[y / (double)x][0]++;
                else
                    unitVec[y / (double)x][1]++;
            }
            int max = 0;
            foreach(double key in  unitVec.Keys)
            {
                max = unitVec[key][0] > max ? unitVec[key][0] : max;
                max = unitVec[key][1] > max ? unitVec[key][1] : max;
            }
            Console.Write(max);
        }
    }
}
