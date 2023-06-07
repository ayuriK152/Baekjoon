using System;

namespace AlgorithmStudy
{
    class boj15803
    {
        public static void Main(string[] args)
        {
            int[,] vectors = new int[2, 3];
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split();
                vectors[0, i] = int.Parse(input[0]);
                vectors[1, i] = int.Parse(input[1]);
            }

            if (CCW(vectors[0,1] - vectors[0, 0], vectors[1, 1] - vectors[1, 0],
                (vectors[0, 2] - vectors[0, 0]) - (vectors[0, 1] - vectors[0, 0]), (vectors[1, 2] - vectors[1, 0]) - (vectors[1, 1] - vectors[1, 0])) != 0)
                Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
            else
                Console.WriteLine("WHERE IS MY CHICKEN?");

            int CCW(int x1, int y1, int x2, int y2)
            {
                return x1 * y2 - x2 * y1;
            }
        }
    }
}
