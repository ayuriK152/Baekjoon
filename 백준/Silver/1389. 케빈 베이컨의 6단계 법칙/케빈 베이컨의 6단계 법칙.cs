using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AlgorithmStudy
{
    class boj1389
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

            string[] input = sr.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            for (int i = 0; i < n; i++)
                dic.Add(i + 1, new List<int>());

            for (int i = 0; i < m; i++)
            {
                input = sr.ReadLine().Split();
                int a = int.Parse(input[0]), b = int.Parse(input[1]);
                if (!dic[a].Contains(b))
                    dic[a].Add(b);
                if (!dic[b].Contains(a))
                    dic[b].Add(a);
            }

            int[] numCounts = new int[n];
            for (int i = 1; i <= n; i++)
            {
                Queue queue = new Queue();
                List<int> visited = new List<int>();
                queue.Enqueue(i);
                visited.Add(i);
                int layer = 1, count = 1;
                while (queue.Count > 0)
                {
                    int current = (int)queue.Dequeue();
                    foreach (int j in dic[current])
                    {
                        if (!visited.Contains(j))
                        {
                            queue.Enqueue(j);
                            visited.Add(j);
                            numCounts[i - 1] += layer;
                        }
                    }
                    count--;
                    if (count == 0)
                    {
                        count = queue.Count;
                        layer++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (numCounts[i] == numCounts.Min())
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }
    }
}
