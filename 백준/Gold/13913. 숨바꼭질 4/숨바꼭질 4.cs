using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmStudy
{
    class boj13913
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split();
            bool[] check = new bool[200001];
            int[] times = new int[200001];
            int n = int.Parse(input[0]), k = int.Parse(input[1]);

            Queue queue = new Queue();

            Pair init = new Pair(0, n);
            init.trace.Add(n);
            queue.Enqueue(init);
            check[n] = true;
            int time = -1;
            List<int> path = init.trace;

            if (n > k)
            {
                time = n - k;

                sb.AppendLine(time.ToString());
                for(int i = n; i >= k; i--)
                    sb.Append(i.ToString() + " ");
            }

            else if (n * 2 - k > k - n)
            {
                time = k - n;

                sb.AppendLine(time.ToString());
                for (int i = n; i <= k; i++)
                    sb.Append(i.ToString() + " ");
            }

            else
            {
                while (queue.Count > 0)
                {
                    Pair current = (Pair)queue.Dequeue();
                    if (current.time < times[current.pos])
                        current.time = times[current.pos];

                    if (current.pos == k)
                    {
                        if (time == -1 || time > current.time)
                        {
                            path = current.trace;
                            time = current.time;
                            break;
                        }
                    }
                    else if (current.pos * 2 == k || current.pos - 1 == k || current.pos + 1 == k)
                    {
                        if (time == -1 || time > current.time + 1)
                        {
                            path = current.trace;
                            path.Add(k);
                            time = current.time + 1;
                            break;
                        }
                    }

                    if (current.pos < k)
                    {
                        if (!check[current.pos * 2])
                        {
                            queue.Enqueue(new Pair(current.time + 1, current.pos * 2, current));
                            times[current.pos * 2] = current.time + 1;
                            check[current.pos * 2] = true;
                        }
                        else if (times[current.pos * 2] > current.time + 1)
                        {

                            times[current.pos * 2] = current.time + 1;
                        }

                        if (!check[current.pos + 1])
                        {
                            queue.Enqueue(new Pair(current.time + 1, current.pos + 1, current));
                            times[current.pos + 1] = current.time + 1;
                            check[current.pos + 1] = true;
                        }
                        else if (times[current.pos + 1] > current.time + 1)
                        {

                            times[current.pos + 1] = current.time + 1;
                        }
                    }

                    if (current.pos > 0)
                    {
                        if (!check[current.pos - 1])
                        {
                            queue.Enqueue(new Pair(current.time + 1, current.pos - 1, current));
                            times[current.pos - 1] = current.time + 1;
                            check[current.pos - 1] = true;
                        }
                        else if (times[current.pos - 1] > current.time + 1)
                        {

                            times[current.pos - 1] = current.time + 1;
                        }
                    }
                }

                sb.AppendLine(time.ToString());
                foreach (int i in path)
                    sb.Append(i.ToString() + " ");
            }
            Console.Write(sb);
        }

        class Pair
        {
            public int time, pos;
            public List<int> trace;
            public Pair(int time, int pos)
            {
                this.time = time;
                this.pos = pos;
                this.trace = new List<int>();
            }

            public Pair(int time, int pos, Pair legacy)
            {
                this.time = time;
                this.pos = pos;
                this.trace = legacy.trace.ToList();
                this.trace.Add(pos);
            }
        }
    }
}
