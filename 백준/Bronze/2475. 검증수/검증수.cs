using System;

namespace AlgorithmStudy
{
    class boj2475
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int total = 0;
            total += (int)Math.Pow(int.Parse(temp[0]), 2) + (int)Math.Pow(int.Parse(temp[1]), 2) + (int)Math.Pow(int.Parse(temp[2]), 2) + (int)Math.Pow(int.Parse(temp[3]), 2) + (int)Math.Pow(int.Parse(temp[4]), 2);
            Console.WriteLine(total % 10);
        }
    }
}