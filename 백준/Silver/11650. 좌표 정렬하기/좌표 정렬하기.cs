using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmStudy
{
    class boj11650
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            string[] input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                int x = int.Parse(input[0]), y = int.Parse(input[1]);
                if (!dic.ContainsKey(x))
                    dic.Add(x, new List<int>());
                dic[x].Add(y);
            }
            int[] keys = dic.Keys.ToArray();
            Array.Sort(keys);
            StringBuilder sb = new StringBuilder();
            foreach (int x in keys)
            {
                dic[x].Sort();
                foreach (int y in dic[x])
                    sb.AppendLine(x.ToString() + " " + y.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
