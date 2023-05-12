using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmStudy
{
    class boj2667
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int n = int.Parse(sr.ReadLine());
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string input = sr.ReadLine();
                for (int j = 0; j < n; j++)
                    arr[j, i] = int.Parse(input[j].ToString());
            }

            List<int> counts = new List<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[j, i] == 1)
                    {
                        Queue queue = new Queue();
                        queue.Enqueue(new Pair(j, i));
                        arr[j, i] = 0;
                        int count = 0;
                        while (queue.Count > 0)
                        {
                            count++;
                            Pair p = (Pair)queue.Dequeue();
                            
                            if (p.x > 0)
                                if (arr[p.x - 1, p.y] == 1)
                                {
                                    arr[p.x - 1, p.y] = 0;
                                    queue.Enqueue(new Pair(p.x - 1, p.y));
                                }
                            if (p.y > 0)
                                if (arr[p.x, p.y - 1] == 1)
                                {
                                    arr[p.x, p.y - 1] = 0;
                                    queue.Enqueue(new Pair(p.x, p.y - 1));
                                }
                            if (p.x < n - 1)
                                if (arr[p.x + 1, p.y] == 1)
                                {
                                    arr[p.x + 1, p.y] = 0;
                                    queue.Enqueue(new Pair(p.x + 1, p.y));
                                }
                            if (p.y < n - 1)
                                if (arr[p.x, p.y + 1] == 1)
                                {
                                    arr[p.x, p.y + 1] = 0;
                                    queue.Enqueue(new Pair(p.x, p.y + 1));
                                }
                        }
                        counts.Add(count);
                    }
                }
            }
            counts.Sort();

            Console.WriteLine(counts.Count);
            for (int i = 0; i < counts.Count; i++)
                Console.WriteLine(counts[i]);
        }

        class Pair
        {
            public int x, y;
            public Pair(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
        }
    }
}
