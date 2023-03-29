using System;

namespace AlgorithmStudy
{
    class boj2839
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = -1;

            for (int i = n / 5; i >= 0; i--)
            {
                if ((n - i * 5) % 3 == 0)
                {
                    result = i + (n - i * 5) / 3;
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}