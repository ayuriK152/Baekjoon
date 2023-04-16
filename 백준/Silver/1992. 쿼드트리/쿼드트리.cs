using System;
using System.IO;
using System.Security.Policy;

namespace AlgorithmStudy
{
    class boj1992
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(sr.ReadLine());
            int[,] pixels = new int[n, n];
            string input;
            for (int y = 0; y < n; y++)
            {
                input = sr.ReadLine();
                for (int x = 0; x < n; x++)
                {
                    pixels[x, y] = int.Parse(input[x].ToString());
                }
            }
            sr.Close();

            Console.WriteLine(CheckPixel(0, n - 1, 0, n - 1));

            string CheckPixel(int minX, int maxX, int minY, int maxY)
            {
                int target = pixels[minX, minY];
                bool diff = false;

                for (int y = minY; y <= maxY; y++)
                {
                    for (int x = minX; x <= maxX; x++)
                    {
                        if (target != pixels[x, y])
                        {
                            diff = true;
                            break;
                        }
                    }
                    if (diff)
                        break;
                }

                if (!diff)
                    return target.ToString();
                else
                {
                    string ret = "(";
                    int unit = (maxX - minX + 1) / 2;

                    ret += CheckPixel(minX, minX + unit - 1, minY, minY + unit - 1);
                    ret += CheckPixel(minX + unit, maxX, minY, minY + unit - 1);
                    ret += CheckPixel(minX, minX + unit - 1, minY + unit, maxY);
                    ret += CheckPixel(minX + unit, maxX, minY + unit, maxY);

                    return ret + ")";
                }
            }
        }
    }
}
