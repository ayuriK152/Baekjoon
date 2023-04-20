using System;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj11022
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(sr.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] input = sr.ReadLine().Split();
                sb.AppendLine($"Case #{i + 1}: {int.Parse(input[0])} + {int.Parse(input[1])} = " + (int.Parse(input[0]) + int.Parse(input[1])).ToString());
            }
            sr.Close();
            Console.WriteLine(sb);
        }
    }
}
