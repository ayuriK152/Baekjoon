using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj2720
    {
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < t; i++)
            {
                int total = int.Parse(Console.ReadLine());
                int[] counts = new int[4];
                counts[0] = total / 25;
                total %= 25;
                counts[1] = total / 10;
                total %= 10;
                counts[2] = total / 5;
                total %= 5;
                counts[3] = total / 1;
                sb.Append(counts[0] + " " + counts[1] + " " + counts[2] + " " + counts[3] + "\n");
            }
            Console.Write(sb);
        }
    }
}
