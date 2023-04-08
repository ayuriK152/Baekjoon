using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmStudy
{
    class boj10814
    {
        public static void Main(string[] args)
        {
            List<string>[] names = new List<string>[200];
            for (int i = 0; i < 200; i++)
                names[i] = new List<string>();
            int[] ages;
            int n = int.Parse(Console.ReadLine());
            ages = new int[n];
            string[] input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                ages[i] = int.Parse(input[0]);
                names[ages[i] - 1].Add(input[1]);
            }
            Array.Sort(ages);
            StringBuilder result = new StringBuilder();
            foreach (int age in ages)
            {
                foreach (string name in names[age - 1])
                {
                    result.AppendLine(age.ToString() + " " + name);
                }
                names[age - 1].Clear();
            }
            Console.WriteLine(result);
        }
    }
}