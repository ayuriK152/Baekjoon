using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj1780
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(sr.ReadLine());
            int[,] arr = new int[n, n];
            string[] input;

            for (int i = 0; i < n; i++)
            {
                input = sr.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(input[j]);
                }
            }

            int[] counts = new int[3];
            CheckPaper(0, n, 0, n);
            Console.WriteLine(counts[0]);
            Console.WriteLine(counts[1]);
            Console.WriteLine(counts[2]);

            void CheckPaper(int startX, int endX, int startY, int endY)
            {
                int checkNum = arr[startX, startY];
                bool isDiff = false;
                for (int i = startY; i < endY; i++)
                {
                    for (int j = startX; j < endX; j++)
                    {
                        if (checkNum != arr[j, i])
                        {
                            isDiff = true;
                            break;
                        }
                    }
                    if (isDiff)
                        break;
                }

                if (isDiff)
                {
                    int unit = (endX - startX + 1) / 3;
                    CheckPaper(startX, startX + unit, startY, startY + unit);
                    CheckPaper(startX + unit, startX + unit * 2, startY, startY + unit);
                    CheckPaper(startX + unit * 2, endX, startY, startY + unit);

                    CheckPaper(startX, startX + unit, startY + unit, startY + unit * 2);
                    CheckPaper(startX + unit, startX + unit * 2, startY + unit, startY + unit * 2);
                    CheckPaper(startX + unit * 2, endX, startY + unit, startY + unit * 2);

                    CheckPaper(startX, startX + unit, startY + unit * 2, endY);
                    CheckPaper(startX + unit, startX + unit * 2, startY + unit * 2, endY);
                    CheckPaper(startX + unit * 2, endX, startY + unit * 2, endY);
                }

                else
                    counts[checkNum + 1]++;
            }
        }
    }
}
