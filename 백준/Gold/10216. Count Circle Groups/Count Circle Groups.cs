using System;
using System.Collections;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    internal class boj10216
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int t = int.Parse(Console.ReadLine());
            for (; t > 0; t--)
            {
                int n = int.Parse(Console.ReadLine());
                bool[,] edges = new bool[n, n];
                bool[] isChecked = new bool[n];
                Base[] bases = new Base[n];

                string[] input;
                for (int i = 0; i < n; i++)
                {
                    input = Console.ReadLine().Split(' ');
                    bases[i] = new Base(i, int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]));
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (Math.Pow(bases[i].x - bases[j].x, 2) + Math.Pow(bases[i].y - bases[j].y, 2) <= Math.Pow(bases[i].r + bases[j].r, 2))
                        {
                            edges[i, j] = true;
                            edges[j, i] = true;
                        }
                    }
                }

                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (isChecked[i])
                        continue;
                    count++;
                    Queue queue = new Queue();
                    queue.Enqueue(bases[i]);
                    isChecked[i] = true;
                    while (queue.Count > 0)
                    {
                        Base current = (Base)queue.Dequeue();
                        for (int j = 0; j < n; j++)
                        {
                            if (edges[current.index, j] && !isChecked[j])
                            {
                                queue.Enqueue(bases[j]);
                                isChecked[j] = true;
                            }
                        }
                    }
                }
                sb.AppendLine(count.ToString());
            }
            sw.Write(sb);
            sw.Close();
        }

        class Base
        {
            public int index, x, y, r;

            public Base(int _index, int _x, int _y, int _r)
            {
                index = _index;
                x = _x;
                y = _y;
                r = _r;
            }
        }
    }
}
