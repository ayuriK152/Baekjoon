using System;

namespace AlgorithmStudy
{
    class boj2230
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            int pivotL = 0, pivotR = 1, result = -1;
            while (pivotR < n)
            {
                int current = arr[pivotR] - arr[pivotL];
                if (current < m)
                {
                    pivotR++;
                }
                else if (current >= m)
                {
                    if (result == -1 || result > current)
                        result = current;
                    pivotL++;
                    if (pivotR == pivotL)
                        pivotR++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
