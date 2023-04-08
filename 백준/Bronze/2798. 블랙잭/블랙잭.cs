using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmStudy
{
    class boj2798
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int[] cards = new int[n];
            input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
                cards[i] = int.Parse(input[i]);
            Array.Sort(cards);
            int last = cards.Length - 1;
            while (true)
                if (cards[last] > m - 2)
                    last--;
                else
                    break;

            List<int> list = new List<int>();
            int temp;
            for (int i = last; i >= 2; i--)
            {
                for (int j = i - 1; j >= 1; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        temp = cards[i] + cards[j] + cards[k];
                        if (temp <= m)
                            list.Add(temp);
                    }
                }
            }
            Console.WriteLine(list.Max());
        }
    }
}