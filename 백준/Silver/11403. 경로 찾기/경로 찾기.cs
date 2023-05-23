using System;
using System.Collections;
using System.Text;

namespace AlgorithmStudy
{
    class boj11403
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[,] edges = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    edges[i, j] = int.Parse(input[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                int[] result = new int[n];
                Queue queue = new Queue();
                queue.Enqueue(i);
                while (queue.Count > 0)
                {
                    int current = (int)queue.Dequeue();
                    for (int j = 0; j < n; j++)
                    {
                        if (edges[current, j] == 1 && result[j] == 0)
                        {
                            result[j] = 1;
                            queue.Enqueue(j);
                        }
                    }
                }
                foreach (int j in result)
                    sb.Append(j + " ");
                sb.Append("\n");
            }

            Console.Write(sb);
        }
    }
}
