using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj2444
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                    sb.Append(" ");
                for (int j = 0; j < i * 2 + 1; j++)
                    sb.Append("*");
                sb.Append("\n");
            }
            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 0; j < n - i - 1; j++)
                    sb.Append(" ");
                for (int j = 0; j < i * 2 + 1; j++)
                    sb.Append("*");
                sb.Append("\n");
            }
            Console.Write(sb);
        }
    }
}
