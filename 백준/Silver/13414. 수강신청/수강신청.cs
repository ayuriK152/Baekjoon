using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmStudy
{
    class boj13414
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split(' ');
            int k = int.Parse(input[0]), l = int.Parse(input[1]);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            List<string> list = new List<string>();
            for (int i = 0; i < l; i++)
            {
                string temp = Console.ReadLine();
                list.Add(temp);
                if (dic.ContainsKey(temp))
                    dic[temp]++;
                else
                    dic.Add(temp, 1);
            }
            int count = 0;
            for (int i = 0; i < l; i++)
            {
                if (count >= k)
                    break;
                if (dic[list[i]] == 1)
                {
                    sb.AppendLine(list[i]);
                    count++;
                }
                else
                    dic[list[i]]--;
            }
            Console.Write(sb);
        }
    }
}
