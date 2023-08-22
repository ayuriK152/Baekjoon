using System;

namespace AlgorithmStudy
{
    class boj17392
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            long count = m;
            if (n > 0)
                input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                count -= int.Parse(input[i]) + 1;
            }

            if (count > n)
                count++;
            long[] space = new long[n + 1];
            space[n] = -1;
            int index = 0;
            long result = 0;
            for (int i = 0; i < count; i++)
            {
                space[index] += 1;
                result += space[index] * space[index];
                if (index == n && space[index] == 0)
                    continue;
                index = index < n ? index + 1 : 0;
            }
            Console.WriteLine(result);
        }
    }
}
