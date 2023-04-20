using System;

namespace AlgorithmStudy
{
    class boj25304
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                result += int.Parse(input[0]) * int.Parse(input[1]);
            }
            if (x == result)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
