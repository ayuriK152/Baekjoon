using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj9742
    {
        static string input, result;
        static int n, count;
        static bool[] check;

        public static void Main(string[] args)
        {
            while (true)
            {
                string temp = Console.ReadLine();
                if (temp == null)
                    break;
                count = 0;
                input = temp.Split(' ')[0];
                n = int.Parse(temp.Split(' ')[1]);
                check = new bool[input.Length];
                result = "No permutation";

                Search(0, "");
                Console.WriteLine($"{temp} = {result}");
            }
        }

        static bool Search(int cnt, string str)
        {
            if (cnt == input.Length)
            {
                if (count == n - 1)
                {
                    result = str;
                    return true;
                }
                count++;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (check[i])
                        continue;
                    check[i] = true;
                    if (Search(cnt + 1, str + input[i]))
                        return true;
                    check[i] = false;
                }
            }
            return false;
        }
    }
}
