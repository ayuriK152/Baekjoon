using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj17219
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StringBuilder sb = new StringBuilder();
            string[] input = sr.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            for (int i = 0; i < n; i++)
            {
                input = sr.ReadLine().Split();
                dic.Add(input[0], input[1]);
            }
            for (int i = 0; i < m; i++)
                sb.AppendLine(dic[sr.ReadLine()]);
            sr.Close();
            Console.Write(sb);
        }
    }
}
