using System;
using System.Collections;

namespace AlgorithmStudy
{
    class boj1697
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            bool[] check = new bool[200001];
            int[] times = new int[200001];
            int n = int.Parse(input[0]), k = int.Parse(input[1]);

            Queue queue = new Queue();
            queue.Enqueue(new Pair(0, n));
            check[n] = true;
            int time = -1;

            while (queue.Count > 0)
            {
                Pair current = (Pair)queue.Dequeue();
                if (current.time != times[current.pos])
                    current.time = times[current.pos];

                if (current.pos * 2 == k || current.pos == k)
                {
                    if (time == -1 || time > current.time)
                        time = current.time;
                }
                else if (current.pos - 1 == k || current.pos + 1 == k)
                {
                    if (time == -1 || time > current.time + 1)
                        time = current.time + 1;
                }
                
                if (current.pos < k)
                {
                    if (!check[current.pos * 2])
                    {
                        queue.Enqueue(new Pair(current.time, current.pos * 2));
                        times[current.pos * 2] = current.time;
                        check[current.pos * 2] = true;
                    }
                    else if (times[current.pos * 2] > current.time)
                        times[current.pos * 2] = current.time;

                    if (!check[current.pos + 1])
                    {
                        queue.Enqueue(new Pair(current.time + 1, current.pos + 1));
                        times[current.pos + 1] = current.time + 1;
                        check[current.pos + 1] = true;
                    }
                    else if (times[current.pos + 1] > current.time + 1)
                        times[current.pos + 1] = current.time + 1;
                }

                if (current.pos > 0)
                {
                    if (!check[current.pos - 1])
                    {
                        queue.Enqueue(new Pair(current.time + 1, current.pos - 1));
                        times[current.pos - 1] = current.time + 1;
                        check[current.pos - 1] = true;
                    }
                    else if (times[current.pos - 1] > current.time + 1)
                        times[current.pos - 1] = current.time + 1;
                }
            }

            Console.WriteLine(time);
        }

        class Pair
        {
            public int time, pos;
            public Pair(int time, int pos)
            {
                this.time = time;
                this.pos = pos;
            }
        }
    }
}
