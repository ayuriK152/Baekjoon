using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj7568
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] weight = new int[n];
            int[] height = new int[n];
            string[] input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                weight[i] = int.Parse(input[0]);
                height[i] = int.Parse(input[1]);
            }

            for (int i = 0; i < n; i++)
            {
                int rank = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                        if (weight[j] > weight[i] && height[j] > height[i])
                            rank++;
                }
                sb.Append(rank.ToString() + " ");
            }
            Console.WriteLine(sb);
        }
    }
}
