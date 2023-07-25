using System;

namespace AlgorithmStudy
{
    class boj20206
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);
            input = Console.ReadLine().Split(' ');
            int[] xPos = new int[2];
            int[] yPos = new int[2];
            xPos[0] = int.Parse(input[0]); xPos[1] = int.Parse(input[1]);
            yPos[0] = int.Parse(input[2]); yPos[1]= int.Parse(input[3]);

            int result = 0, zeroCount = 0;
            bool flag = false;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (a * xPos[i] + b * yPos[j] + c < 0)
                        result--;
                    else if (a * xPos[i] + b * yPos[j] + c > 0)
                        result++;
                    else if (a * xPos[i] + b * yPos[j] + c == 0)
                        zeroCount++;
                }
            }

            if ((result == -4 || result == 4) || (zeroCount == 1 && (result % 2 == 1 || result % 2 == -1)) || (zeroCount == 2 && (result == 2 || result == -2)))
                Console.WriteLine("Lucky");
            else
                Console.WriteLine("Poor");
        }
    }
}
