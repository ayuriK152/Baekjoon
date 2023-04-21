using System;

namespace AlgorithmStudy
{
    class boj10810
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int[] basket = new int[n];
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                for (int j = int.Parse(input[0]) - 1; j <= int.Parse(input[1]) - 1; j++)
                    basket[j] = int.Parse(input[2]);
            }

            foreach (int i in basket)
                Console.Write(i + " ");
        }
    }
}
