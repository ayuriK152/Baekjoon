using System;

namespace AlgorithmStudy
{
    class boj2667
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                if (a == 0 && b == 0)
                    break;
                if (a > b)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }
    }
}
