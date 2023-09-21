using System;

namespace AlgorithmStudy
{
    internal class boj3495
    {
        public static void Main(string[] args)
        {
            string[] initInput = Console.ReadLine().Split(' ');
            int h = int.Parse(initInput[0]), w = int.Parse(initInput[1]);

            int lineCount = 0, dotCount = 0;
            for (int i = 0; i < h; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < w; j++)
                {
                    if (input[j] == '/' || input[j] == '\\')
                        lineCount++;
                    else if (input[j] == '.' && lineCount % 2 == 1)
                        dotCount++;
                }
            }
            Console.Write(lineCount / 2 + dotCount);
        }
    }
}
