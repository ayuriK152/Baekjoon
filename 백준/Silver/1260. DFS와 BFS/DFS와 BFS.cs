using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmStudy
{
    class boj1260
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int n = int.Parse(temp[0]), m = int.Parse(temp[1]), v = int.Parse(temp[2]);
            List<int>[] nodes = new List<int>[n];
            for (int i = 0; i < n; i++)
                nodes[i] = new List<int>();
            for (int i = 0; i < m; i++)
            {
                temp = Console.ReadLine().Split();
                nodes[int.Parse(temp[0]) - 1].Add(int.Parse(temp[1]));
                nodes[int.Parse(temp[1]) - 1].Add(int.Parse(temp[0]));
            }
            for (int i = 0; i < n; i++)
                nodes[i].Sort();

            StringBuilder sb = new StringBuilder();
            bool[] checkDFS = new bool[n];

            DFS(v);
            Console.WriteLine(sb);
            sb.Clear();
            BFS(v);
            Console.WriteLine(sb);

            void BFS(int start)
            {
                Queue queue = new Queue();
                bool[] check = new bool[n];
                int startIndex = Array.IndexOf(nodes, nodes[start - 1]) + 1;
                queue.Enqueue(startIndex);
                check[startIndex - 1] = true;
                sb.Append(startIndex + " ");
                while (queue.Count > 0)
                {
                    int current = (int)queue.Dequeue();
                    for (int i = 0; i < nodes[current - 1].Count; i++)
                    {
                        if (!check[nodes[current - 1][i] - 1])
                        {
                            queue.Enqueue(nodes[current - 1][i]);
                            check[nodes[current - 1][i] - 1] = true;
                            sb.Append(nodes[current - 1][i] + " ");
                        }
                    }
                }
            }

            void DFS(int start)
            {
                sb.Append(start + " ");
                checkDFS[start - 1] = true;
                for (int i = 0; i < nodes[start - 1].Count; i++)
                    if (!checkDFS[nodes[start - 1][i] - 1])
                        DFS(nodes[start - 1][i]);
            }
        }
    }
}