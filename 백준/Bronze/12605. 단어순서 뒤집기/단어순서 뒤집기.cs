using System;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj12605
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = sr.ReadLine().Split();
                for (int j = input.Length - 1; j >= 0; j--)
                    sb.Append(input[j] + " ");
                Console.WriteLine($"Case #{i + 1}: " + sb);
                sb.Clear();
            }
        }
    }
}
