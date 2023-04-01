using System;
using System.Linq;

namespace AlgorithmStudy
{
    class boj1085
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int x = int.Parse(temp[0]),
                y = int.Parse(temp[1]),
                w = int.Parse(temp[2]),
                h = int.Parse(temp[3]);
            int[] distance = new int[4];
            distance[0] = w - x;
            distance[1] = h - y;
            distance[2] = x;
            distance[3] = y;
            Console.WriteLine(distance.Min());
        }
    }
}