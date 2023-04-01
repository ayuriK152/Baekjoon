using System;

namespace AlgorithmStudy
{
    class boj10950
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] results = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                results[i] = int.Parse(temp[0]) + int.Parse(temp[1]);
            }
            foreach(int i in results)
                Console.WriteLine(i);
        }
    }
}