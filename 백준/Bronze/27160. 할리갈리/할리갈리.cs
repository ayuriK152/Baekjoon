using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj27160
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("STRAWBERRY", 0);
            dic.Add("BANANA", 0);
            dic.Add("LIME", 0);
            dic.Add("PLUM", 0);
            int cnt = int.Parse(Console.ReadLine());
            string[] temp;
            for (int i = 0; i < cnt; i++)
            {
                temp = Console.ReadLine().Split();
                int tempValue = dic[temp[0]];
                tempValue += int.Parse(temp[1]);
                dic[temp[0]] = tempValue;
            }
            if (dic.ContainsValue(5))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}