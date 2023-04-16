using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj2630
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(sr.ReadLine());
            int[,] paper = new int[n, n];
            int[] colorCount = new int[2];

            for (int y = 0; y < n; y++)
            {
                string[] input = sr.ReadLine().Split();
                for (int x = 0; x < n; x++)
                {
                    paper[x, y] = int.Parse(input[x]);
                }
            }
            sr.Close();
            CheckColor(0, n - 1, 0, n - 1);
            Console.WriteLine(colorCount[0]);
            Console.WriteLine(colorCount[1]);

            void CheckColor(int minX, int maxX, int minY, int maxY)
            {
                int target = paper[minX, minY];
                bool diff = false;
                for (int y = minY; y <= maxY; y++)
                {
                    for (int x = minX; x <= maxX; x++)
                    {
                        if (paper[x, y] != target)
                        {
                            diff = true;
                            break;
                        }
                    }
                    if (diff)
                        break;
                }

                if (!diff)
                    colorCount[target]++;
                else
                {
                    int unit = (maxX - minX + 1) / 2;
                    CheckColor(minX, minX + unit - 1, minY, minY + unit - 1);
                    CheckColor(minX + unit, maxX, minY, minY + unit - 1);
                    CheckColor(minX, minX + unit - 1, minY + unit, maxY);
                    CheckColor(minX + unit, maxX, minY + unit, maxY);
                }
            }
        }
    }
}
