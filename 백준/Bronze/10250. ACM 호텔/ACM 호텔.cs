using System;

namespace AlgorithmStudy
{
    class boj10250
    {
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string[] input = Console.ReadLine().Split();
                int h = int.Parse(input[0]), w = int.Parse(input[1]), n = int.Parse(input[2]);
                int room;
                if (n % h == 0)
                    room = h * 100 + n / h;
                else
                    room = n % h * 100 + (n / h + 1);
                Console.WriteLine(room);
                t--;
            }
        }
    }
}
