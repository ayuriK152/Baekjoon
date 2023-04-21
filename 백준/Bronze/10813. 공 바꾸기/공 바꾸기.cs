using System;

namespace AlgorithmStudy
{
    class boj10813
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int[] basket = new int[n];
            for (int i = 0; i < n; i++)
                basket[i] = i + 1;
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                int temp = basket[int.Parse(input[0]) - 1];
                basket[int.Parse(input[0]) - 1] = basket[int.Parse(input[1]) - 1];
                basket[int.Parse(input[1]) - 1] = temp;
            }

            foreach (int i in basket)
                Console.Write(i + " ");
        }
    }
}
