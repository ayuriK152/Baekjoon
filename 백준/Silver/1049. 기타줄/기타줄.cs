using System;

namespace AlgorithmStudy
{
    class boj1049
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int minSix = -1, minOne = -1;
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                if (minSix == -1 || minSix > int.Parse(input[0]))
                    minSix = int.Parse(input[0]);

                if (minOne == -1 || minOne > int.Parse(input[1]))
                    minOne = int.Parse(input[1]);
            }

            int countSix = n / 6;
            if (n % 6 != 0)
                countSix++;
            int minCost = countSix * minSix;

            for (int i = countSix - 1; i >= 0; i--)
            {
                int temp;
                if (i == 0)
                    temp = n * minOne;
                else
                    temp = i * minSix + (n - i * 6) * minOne;
                if (minCost > temp)
                    minCost = temp;
            }

            Console.WriteLine(minCost);
        }
    }
}
