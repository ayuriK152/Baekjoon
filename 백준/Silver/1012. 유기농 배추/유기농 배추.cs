using System;

namespace AlgorithmStudy
{
    class boj1012
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int loop = 0;
            while (loop < num)
            {
                loop++;
                string[] temp = Console.ReadLine().Split();
                int m = int.Parse(temp[0]), n = int.Parse(temp[1]), k = int.Parse(temp[2]);
                int[,] mat = new int[m, n];
                for (int i = 0; i < k; i++)
                {
                    temp = Console.ReadLine().Split();
                    mat[int.Parse(temp[0]), int.Parse(temp[1])] = 1;
                }

                int count = 0;
                for (int y = 0; y < n; y++)
                {
                    for (int x = 0; x < m; x++)
                    {
                        if (CheckMat(mat, x, y, m, n))
                            count++;
                    }
                }
                Console.WriteLine(count);
            }

            bool CheckMat(int[,] arr, int x, int y, int maxX, int maxY)
            {
                if (arr[x, y] == 1)
                {
                    arr[x, y]++;
                    if (x - 1 >= 0)
                        CheckMat(arr, x - 1, y, maxX, maxY);
                    if (y - 1 >= 0)
                        CheckMat(arr, x, y - 1, maxX, maxY);
                    if (x + 1 < maxX)
                        CheckMat(arr, x + 1, y, maxX, maxY);
                    if (y + 1 < maxY)
                        CheckMat(arr, x, y + 1, maxX, maxY);
                    return true;
                }
                else
                    return false;
            }

        }
    }
}