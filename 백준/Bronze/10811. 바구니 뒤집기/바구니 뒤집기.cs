using System;

namespace AlgorithmStudy
{
    class boj10811
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = i + 1;

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                int a = int.Parse(input[0]), b = int.Parse(input[1]);
                int[] temp = new int[b - a + 1];
                int index = 0;
                for (int j = b - 1; j >= a - 1; j--)
                    temp[index++] = arr[j];
                index = 0;
                for (int j = a - 1; j < b; j++)
                    arr[j] = temp[index++];
            }

            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}
