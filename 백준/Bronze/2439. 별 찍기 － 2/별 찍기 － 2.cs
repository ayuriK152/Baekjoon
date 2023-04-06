using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj2439
    {
        public static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < cnt; i++)
            {
                for (int j = 0; j < cnt - (i + 1); j++)
                    sb.Append(" ");
                for (int j = 0; j < i; j++)
                    sb.Append("*");
                sb.AppendLine("*");
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);
        }
    }
}