using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj5619
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            List<int> selected = new List<int>(new int[] { arr[0], arr[1], arr[2] });

            if (n > 3) selected.Add(arr[3]);

            int[] result = n > 3 ? new int[12] : new int[6];
            int index = 0;
            for (int i = 0; i < selected.Count; i++)
            {
                for (int j = 0; j < selected.Count; j++)
                {
                    if (i == j)
                        continue;
                    result[index++] = int.Parse($"{selected[i]}{selected[j]}");
                }
            }
            Array.Sort(result);
            Console.Write(result[2]);
        }
    }
}
