using System;
using System.Collections;
using System.IO;

namespace AlgorithmStudy
{
    class boj2178
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            string[] numInput = sr.ReadLine().Split();
            int n = int.Parse(numInput[0]), m = int.Parse(numInput[1]);
            int[,] maze = new int[m, n];
            bool[,] isChecked = new bool[m, n];
            PositionPair target = new PositionPair(m - 1, n - 1);

            string input;
            for (int y = 0; y < n; y++)
            {
                input = sr.ReadLine();
                for (int x = 0; x < m; x++)
                {
                    
                    maze[x, y] = int.Parse(input[x].ToString());
                }
            }
            sr.Close();

            Queue queue = new Queue();
            queue.Enqueue(new PositionPair(0, 0));
            isChecked[0, 0] = true;
            int count = 1, depth = 0;
            while (true)
            {
                count--;
                PositionPair current = (PositionPair)queue.Dequeue();
                if (current.x == target.x && current.y == target.y)
                    break;

                if (current.x > 0)
                {
                    if (maze[current.x - 1, current.y] == 1 && !isChecked[current.x - 1, current.y])
                    {
                        queue.Enqueue(new PositionPair(current.x - 1, current.y));
                        isChecked[current.x - 1, current.y] = true;
                    }
                }
                if (current.y > 0)
                {
                    if (maze[current.x, current.y - 1] == 1 && !isChecked[current.x, current.y - 1])
                    {
                        queue.Enqueue(new PositionPair(current.x, current.y - 1));
                        isChecked[current.x, current.y - 1] = true;
                    }
                }
                if (current.x < m - 1)
                {
                    if (maze[current.x + 1, current.y] == 1 && !isChecked[current.x + 1, current.y])
                    {
                        queue.Enqueue(new PositionPair(current.x + 1, current.y));
                        isChecked[current.x + 1, current.y] = true;
                    }
                }
                if (current.y < n - 1)
                {
                    if (maze[current.x, current.y + 1] == 1 && !isChecked[current.x, current.y + 1])
                    {
                        queue.Enqueue(new PositionPair(current.x, current.y + 1));
                        isChecked[current.x, current.y + 1] = true;
                    }
                }

                if (count == 0)
                {
                    count = queue.Count;
                    depth++;
                }
            }

            Console.WriteLine(depth + 1);
        }

        class PositionPair
        {
            public int x, y;

            public PositionPair(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
        }
    }
}
