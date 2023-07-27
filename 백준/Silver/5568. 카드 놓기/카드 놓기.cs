using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj5568
    {
        static HashSet<string> list = new HashSet<string>();
        static int n;
        static int k;
        static string[] nums;
        static bool[] check;
        public static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            nums = new string[n];
            check = new bool[n];
            for (int i = 0; i < n; i++)
                nums[i] = Console.ReadLine();
            Assemble(0, "");
            Console.WriteLine(list.Count);
        }

        static void Assemble(int len, string str)
        {
            if (len == k)
                list.Add(str);
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (check[i])
                        continue;
                    check[i] = true;
                    Assemble(len + 1, str + nums[i]);
                    check[i] = false;
                }
            }
        }
    }
}
