using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmStudy
{
    class boj1138
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            List<int> indexes = new List<int>();
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
                indexes.Add(i);
            }

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[indexes[arr[i]]] = i + 1;
                indexes.RemoveAt(arr[i]);
            }

            foreach (int i in result)
                sb.Append(i + " ");
            Console.Write(sb);
        }
    }
}
