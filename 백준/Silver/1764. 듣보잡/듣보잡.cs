using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj1764
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            string[] input = sr.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
                dic.Add(sr.ReadLine(), 0);
            for (int i = 0; i < m; i++)
            {
                input = sr.ReadLine().Split();
                if (dic.ContainsKey(input[0]))
                    dic[input[0]]++;
            }
            sr.Close();

            List<string> names = new List<string>();
            int count = 0;
            foreach (string s in dic.Keys)
            {
                if (dic[s] > 0)
                {
                    names.Add(s);
                    count++;
                }
            }
            names.Sort();
            foreach (string s in names)
                sb.AppendLine(s);
            Console.WriteLine(count);
            Console.WriteLine(sb);
        }
    }
}
