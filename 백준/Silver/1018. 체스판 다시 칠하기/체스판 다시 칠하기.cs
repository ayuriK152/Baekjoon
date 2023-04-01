using System;

namespace AlgorithmStudy
{
    class boj1018
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int n = int.Parse(temp[0]), m = int.Parse(temp[1]);
            string[] board = new string[n];
            for (int i = 0; i < n; i++)
                board[i] = Console.ReadLine();
            int result = 33;
            for (int y = 0; y < n - 7; y++)
            {
                for (int x = 0; x < m - 7; x++)
                {
                    int count = 0;
                    for (int i = 0 + y; i < 8 + y; i++)
                    {
                        for (int j = 0 + x; j < 8 + x; j++)
                        {
                            if (board[i][j].Equals('W') && (i + j) % 2 == 0)
                                count++;
                            if (board[i][j].Equals('B') && (i + j) % 2 == 1)
                                count++;
                        }
                    }
                    if (count > 32)
                        count = 64 - count;
                    if (count < result)
                        result = count;
                }
            }
            Console.WriteLine(result);
        }
    }
}