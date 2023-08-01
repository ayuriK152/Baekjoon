using System;

namespace AlgorithmStudy
{
    class boj1182
    {
        static int[] arr;
        static int n, s, count = 0;
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            n = int.Parse(input[0]); s = int.Parse(input[1]);
            arr = new int[n];
            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(input[i]);

            Search(0, 0);
            if (s == 0) count -= 1;
            Console.WriteLine(count);
        }

        static void Search(int idx, int sum)
        {
            if (sum == s && idx == n)
                count++;
            else if (idx < n)
            {
                Search(idx + 1, sum + arr[idx]);
                Search(idx + 1, sum);
            }
        }
    }
}
