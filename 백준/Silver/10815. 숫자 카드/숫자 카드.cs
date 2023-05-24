using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj10815
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] cards = new int[n];
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
                cards[i] = int.Parse(input[i]);
            Array.Sort(cards);

            int m = int.Parse(Console.ReadLine());
            int[] nums = new int[m];
            input = Console.ReadLine().Split();
            for (int i = 0; i < m; i++)
                nums[i] = int.Parse(input[i]);

            for (int i = 0; i < m; i++)
            {
                if (ParametricSearch(0, n - 1, nums[i]))
                    sb.Append("1 ");
                else
                    sb.Append("0 ");
            }

            Console.WriteLine(sb);

            bool ParametricSearch(int min, int max, int value)
            {
                if ((min == max && cards[min] != value) || min > max)
                    return false;
                int mid = (min + max) / 2;
                if (cards[mid] == value)
                    return true;
                else
                {
                    if (cards[mid] < value)
                        return ParametricSearch(mid + 1, max, value);
                    else
                        return ParametricSearch(min, mid - 1, value);
                }
            }
        }
    }
}
