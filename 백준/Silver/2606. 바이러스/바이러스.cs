using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmStudy
{
    class boj2606
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            int n = int.Parse(sr.ReadLine());
            int m = int.Parse(sr.ReadLine());
            string[] input;
            for (int i = 0; i < m; i++)
            {
                input = sr.ReadLine().Split();
                int a = int.Parse(input[0]), b = int.Parse(input[1]);
                if (!dic.ContainsKey(a))
                    dic.Add(a, new List<int>());
                if (!dic.ContainsKey(b))
                    dic.Add(b, new List<int>());
                dic[a].Add(b);
                dic[b].Add(a);
            }
            
            Queue queue = new Queue();
            List<int> counted = new List<int>();
            queue.Enqueue(1);
            counted.Add(1);
            int depth = 1, count = 0;
            while (queue.Count > 0)
            {
                count++;
                depth--;
                int current = (int)queue.Dequeue();
                foreach (int a in dic[current])
                {
                    if (!counted.Contains(a))
                    {
                        queue.Enqueue(a);
                        counted.Add(a);
                    }
                }
                if (depth == 0)
                    depth = queue.Count;
            }
            Console.WriteLine(count - 1);
        }
    }
}
