using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj2742
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = n; i > 0; i--)
                sb.AppendLine(i.ToString());
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);
        }
    }
}