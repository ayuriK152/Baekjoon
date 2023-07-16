using System;
using System.Collections;

namespace AlgorithmStudy
{
    class boj1926
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int[,] arr = new int[m, n];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    arr[j, i] = int.Parse(input[j]);
                }
            }

            int max = 0;
            int arts = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[j, i] == 1)
                    {
                        arts++;
                        int temp = BFS(new Pair(j, i));
                        max = max < temp ? temp : max;
                    }
                }
            }

            Console.WriteLine(arts);
            Console.Write(max);

            int BFS(Pair pos)
            {
                int count = 0;
                Queue q = new Queue();
                q.Enqueue(pos);
                arr[pos.x, pos.y] = 0;
                while (q.Count > 0)
                {
                    Pair current = q.Dequeue() as Pair;
                    count++;
                    if (current.x > 0)
                        if (arr[current.x - 1, current.y] == 1)
                        {
                            arr[current.x - 1, current.y] = 0;
                            q.Enqueue(new Pair(current.x - 1, current.y));
                        }
                    if (current.y > 0)
                        if (arr[current.x, current.y - 1] == 1)
                        {
                            arr[current.x, current.y - 1] = 0;
                            q.Enqueue(new Pair(current.x, current.y - 1));
                        }
                    if (current.x < m - 1)
                        if (arr[current.x + 1, current.y] == 1)
                        {
                            arr[current.x + 1, current.y] = 0;
                            q.Enqueue(new Pair(current.x + 1, current.y));
                        }
                    if (current.y < n - 1)
                        if (arr[current.x, current.y + 1] == 1)
                        {
                            arr[current.x, current.y + 1] = 0;
                            q.Enqueue(new Pair(current.x, current.y + 1));
                        }
                }
                return count;
            }
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
