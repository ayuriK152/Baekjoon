using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj1316
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                char temp = input[0];
                List<char> check = new List<char>();
                bool isGroup = true;
                for (int j = 1; j < input.Length; j++)
                {
                    if (check.Contains(input[j]))
                    {
                        isGroup = false;
                        break;
                    }
                    if (!input[j].Equals(temp))
                    {
                        check.Add(temp);
                        temp = input[j];
                    }
                }
                if (isGroup)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
