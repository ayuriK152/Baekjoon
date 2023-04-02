using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmStudy
{
    class boj1181
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> words = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (!words.ContainsKey(input))
                    words.Add(input, input.Length);
            }
            List<string> result = new List<string>();
            for (int i = 1; i < words.Values.Max() + 1; i++)
            {
                List<string> temp = new List<string>();
                foreach (string word in words.Keys)
                    if (words[word] == i)
                        temp.Add(word);
                temp.Sort();
                foreach (string word in temp)
                    result.Add(word);
            }
            foreach(string word in result)
                Console.WriteLine(word);
        }
    }
}