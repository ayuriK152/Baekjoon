using System;
using System.Collections;
using System.IO;

namespace AlgorithmStudy
{
    class boj1303
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            string[] numInput = sr.ReadLine().Split();
            int n = int.Parse(numInput[0]), m = int.Parse(numInput[1]);
            int[,] tile = new int[n, m]; 
            for (int i = 0; i < m; i++)
            {
                string input = sr.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    if (input[j].Equals('W'))
                        tile[j, i] = 1;
                    else
                        tile[j, i] = 2;
                }
            }
            sr.Close();

            int powerW = 0, powerB = 0;

            for (int y = 0; y < m; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (tile[x, y].Equals(1))
                    {
                        Queue queue = new Queue();
                        queue.Enqueue(new Pair(x, y));
                        tile[x, y] = 0;
                        int count = 0;
                        while(queue.Count > 0)
                        {
                            count++;
                            Pair current = (Pair)queue.Dequeue();

                            if (current.x > 0)
                            {
                                if (tile[current.x - 1, current.y].Equals(1))
                                {
                                    queue.Enqueue(new Pair(current.x - 1, current.y));
                                    tile[current.x - 1, current.y] = 0;
                                }
                            }
                            if (current.y > 0)
                            {
                                if (tile[current.x, current.y - 1].Equals(1))
                                {
                                    queue.Enqueue(new Pair(current.x, current.y - 1));
                                    tile[current.x, current.y - 1] = 0;
                                }
                            }
                            if (current.x < n - 1)
                            {
                                if (tile[current.x + 1, current.y].Equals(1))
                                {
                                    queue.Enqueue(new Pair(current.x + 1, current.y));
                                    tile[current.x + 1, current.y] = 0;
                                }
                            }
                            if (current.y < m - 1)
                            {
                                if (tile[current.x, current.y + 1].Equals(1))
                                {
                                    queue.Enqueue(new Pair(current.x, current.y + 1));
                                    tile[current.x, current.y + 1] = 0;
                                }
                            }
                        }
                        powerW += count * count;
                    }

                    else if (tile[x, y].Equals(2))
                    {
                        Queue queue = new Queue();
                        queue.Enqueue(new Pair(x, y));
                        tile[x, y] = 0;
                        int count = 0;
                        while (queue.Count > 0)
                        {
                            count++;
                            Pair current = (Pair)queue.Dequeue();

                            if (current.x > 0)
                            {
                                if (tile[current.x - 1, current.y].Equals(2))
                                {
                                    queue.Enqueue(new Pair(current.x - 1, current.y));
                                    tile[current.x - 1, current.y] = 0;
                                }
                            }
                            if (current.y > 0)
                            {
                                if (tile[current.x, current.y - 1].Equals(2))
                                {
                                    queue.Enqueue(new Pair(current.x, current.y - 1));
                                    tile[current.x, current.y - 1] = 0;
                                }
                            }
                            if (current.x < n - 1)
                            {
                                if (tile[current.x + 1, current.y].Equals(2))
                                {
                                    queue.Enqueue(new Pair(current.x + 1, current.y));
                                    tile[current.x + 1, current.y] = 0;
                                }
                            }
                            if (current.y < m - 1)
                            {
                                if (tile[current.x, current.y + 1].Equals(2))
                                {
                                    queue.Enqueue(new Pair(current.x, current.y + 1));
                                    tile[current.x, current.y + 1] = 0;
                                }
                            }
                        }
                        powerB += count * count;
                    }
                }
            }

            Console.WriteLine(powerW + " " + powerB);
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
