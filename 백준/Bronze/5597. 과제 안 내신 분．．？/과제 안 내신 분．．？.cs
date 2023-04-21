using System;

namespace AlgorithmStudy
{
    class boj5597
    {
        public static void Main(string[] args)
        {
            bool[] check = new bool[30];
            for (int i = 0; i < 28; i++)
                check[int.Parse(Console.ReadLine()) - 1] = true;
            for (int i = 0; i < 30; i++)
                if (!check[i])
                    Console.WriteLine(i + 1);
        }
    }
}
