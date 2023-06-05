using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj1485
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long[,] pos = new long[2, 4];
                long[] len = new long[3];
                long[] len2 = new long[3];
                long[,] vectors = new long[2, 3];
                for (int j = 0; j < 4; j++)
                {
                    string[] input = Console.ReadLine().Split();
                    pos[0, j] = long.Parse(input[0]);
                    pos[1, j] = long.Parse(input[1]);
                }
                for (int j = 1; j < 4; j++)
                {
                    len[j - 1] = (long)Math.Pow(pos[0, 0] - pos[0, j], 2) + (long)Math.Pow(pos[1, 0] - pos[1, j], 2);
                    len2[j - 1] = (long)Math.Pow(pos[0, 3] - pos[0, 3 - j], 2) + (long)Math.Pow(pos[1, 3] - pos[1, 3 - j], 2);
                }
                Array.Sort(len);
                Array.Sort(len2);
                if (len[0] == len[1] && len[0] + len[1] == len[2] && len2[0] == len2[1] && len2[0] + len2[1] == len2[2])
                    sb.AppendLine("1");
                else
                    sb.AppendLine("0");
            }
            Console.Write(sb);
        }
    }
}
