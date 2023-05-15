using System;

namespace AlgorithmStudy
{
    class boj4796
    {
        public static void Main(string[] args)
        {
            int count = 1;
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                int l = int.Parse(input[0]), p = int.Parse(input[1]), v = int.Parse(input[2]);
                if (l + p + v == 0)
                    break;
                int result = v / p * l;
                result += v % p >= l ? l : v % p;
                Console.WriteLine("Case " + count + ": " + result);
                count++;
            }
        }
    }
}
