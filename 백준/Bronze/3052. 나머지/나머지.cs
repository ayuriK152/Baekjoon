using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj3052
    {
        public static void Main(string[] args)
        {
            int input;
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                input = int.Parse(Console.ReadLine());
                int value = input % 42;
                if (!list.Contains(value))
                    list.Add(value);
            }
            Console.WriteLine(list.Count);
        }
    }
}