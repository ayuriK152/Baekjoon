using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace AlgorithmStudy
{
    class boj9933
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Hashtable hash = new Hashtable();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string reversed = new string(input.Reverse().ToArray());
                if (hash.ContainsKey(reversed) || input.Equals(reversed))
                {
                    int len = input.Length;
                    char mid = input[len / 2];
                    result.Append(len + " " + mid);
                }
                hash.Add(input, reversed);
            }
            Console.WriteLine(result);
        }
    }
}