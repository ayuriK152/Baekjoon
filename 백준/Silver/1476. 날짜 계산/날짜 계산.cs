using System;

namespace AlgorithmStudy
{
    class boj1476
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int e = int.Parse(input[0]), s = int.Parse(input[1]), m = int.Parse(input[2]);
            e %= 15;
            m %= 19;
            for (int i = 0; ; i++)
            {
                if ((28 * i + s) % 15 == e && (28 * i + s) % 19 == m)
                {
                    Console.WriteLine(28 * i + s);
                    break;
                }
            }
        }
    }
}
