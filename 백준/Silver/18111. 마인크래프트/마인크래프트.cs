using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AlgorithmStudy
{
    class boj18111
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            Dictionary<int, int> dic = new Dictionary<int, int>();
            string[] input = sr.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]), b = int.Parse(input[2]);
            for (int i = 0; i < n; i++)
            {
                input = sr.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    if (!dic.ContainsKey(int.Parse(input[j])))
                        dic.Add(int.Parse(input[j]), 1);
                    else
                        dic[int.Parse(input[j])]++;
                }
            }
            sr.Close();

            int height = 0, time = -1;
            for (int i = dic.Keys.Min(); i <= dic.Keys.Max(); i++)
            {
                int require = 0;
                int remain = 0;
                int tempTime;
                foreach (int j in dic.Keys)
                {
                    if (i == j)
                        continue;
                    if (i > j)
                        require += (i - j) * dic[j];
                    else
                        remain += (j - i) * dic[j];
                }
                if (remain - require + b < 0)
                    continue;
                tempTime = require + remain * 2;
                if (tempTime < time || time == -1)
                {
                    height = i;
                    time = tempTime;
                }
                else if (tempTime == time && height < i)
                    height = i;
            }
            Console.WriteLine(time + " " + height);
        }
    }
}
