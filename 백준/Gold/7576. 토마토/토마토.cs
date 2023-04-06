using System;
using System.Collections;
using System.Threading;

namespace AlgorithmStudy
{
    class boj7576
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int m = int.Parse(temp[0]), n = int.Parse(temp[1]);
            int totalTomato = m * n;
            int[,] tomatoes = new int[m, n];
            bool[,] isChecked = new bool[m, n];
            Queue queue = new Queue();

            for (int i = 0; i < n; i++)
            {
                temp = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    tomatoes[j, i] = int.Parse(temp[j]);
                    if (tomatoes[j, i] == 1)
                    {
                        isChecked[j, i] = true;
                        string s = j.ToString() + " " + i.ToString();
                        queue.Enqueue(s);
                        totalTomato--;
                    }
                    if (tomatoes[j, i] == -1)
                        totalTomato--;
                }
            }

            int count = 0;
            BFS();
            Console.WriteLine(count);

            void BFS()
            {
                int layerCnt = queue.Count;
                while (queue.Count > 0)
                {
                    layerCnt--;
                    temp = queue.Dequeue().ToString().Split();
                    int x = int.Parse(temp[0]), y = int.Parse(temp[1]);
                    string s;
                    if (x != 0)
                    {
                        if (tomatoes[x - 1, y] == 0 && !isChecked[x - 1, y])
                        {
                            s = (x - 1).ToString() + " " + y.ToString();
                            queue.Enqueue(s);
                            isChecked[x - 1, y] = true;
                            totalTomato--;
                        }
                    }
                    if (x != m - 1)
                    {
                        if (tomatoes[x + 1, y] == 0 && !isChecked[x + 1, y])
                        {
                            s = (x + 1).ToString() + " " + y.ToString();
                            queue.Enqueue(s);
                            isChecked[x + 1, y] = true;
                            totalTomato--;
                        }
                    }
                    if (y != 0)
                    {
                        if (tomatoes[x, y - 1] == 0 && !isChecked[x, y - 1])
                        {
                            s = x.ToString() + " " + (y - 1).ToString();
                            queue.Enqueue(s);
                            isChecked[x, y - 1] = true;
                            totalTomato--;
                        }
                    }
                    if (y != n - 1)
                    {
                        if (tomatoes[x, y + 1] == 0 && !isChecked[x, y + 1])
                        {
                            s = x.ToString() + " " + (y + 1).ToString();
                            queue.Enqueue(s);
                            isChecked[x, y + 1] = true;
                            totalTomato--;
                        }
                    }
                    
                    if (queue.Count > 0 && layerCnt == 0)
                    {
                        count++;
                        layerCnt = queue.Count;
                    }
                }
                if (totalTomato != 0)
                    count = -1;
            }
        }
    }
}