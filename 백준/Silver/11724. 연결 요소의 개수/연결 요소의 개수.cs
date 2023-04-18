using System;
using System.Collections;

namespace AlgorithmStudy
{
    class boj11724
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int[,] nodes = new int[n, n];
            bool[] isChecked = new bool[n];
            for (int i = 0; i < n; i++)
                nodes[i, i] = 1;

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                nodes[int.Parse(input[0]) - 1, int.Parse(input[1]) - 1] = 1;
                nodes[int.Parse(input[1]) - 1, int.Parse(input[0]) - 1] = 1;
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (!isChecked[i])
                {
                    count++;
                    Queue queue = new Queue();
                    queue.Enqueue(i);
                    isChecked[i] = true;
                    while (queue.Count > 0)
                    {
                        int current = (int)queue.Dequeue();
                        for (int j = 0; j < n; j++)
                        {
                            if (j != current && nodes[current, j] == 1 && !isChecked[j])
                            {
                                queue.Enqueue(j);
                                isChecked[j] = true;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
