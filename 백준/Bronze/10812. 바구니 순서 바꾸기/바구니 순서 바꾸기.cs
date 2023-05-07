using System;

namespace AlgorithmStudy
{
    class boj10812
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = i + 1;
            for (int a = 0; a < m; a++)
            {
                input = Console.ReadLine().Split();
                int i = int.Parse(input[0]) - 1, j = int.Parse(input[1]) - 1, k = int.Parse(input[2]) - 1;
                int[] temp = new int[j - i + 1];
                for (int s = 0; s <= j - i; s++)
                {
                    if (k + s > j)
                        k -= j - i + 1;
                    temp[s] = arr[k + s];
                }
                foreach (int s in temp)
                    arr[i++] = s;
            }
            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}
