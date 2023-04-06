using System;
using System.Linq;

namespace AlgorithmStudy
{
    class boj1546
    {
        public static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            double[] scores = new double[cnt];

            string[] temp = Console.ReadLine().Split();
            for (int i = 0; i < cnt; i++)
                scores[i] = int.Parse(temp[i]);
            double max = scores.Max();
            for (int i = 0; i < cnt; i++)
                scores[i] = scores[i] / max * 100;
            Console.WriteLine(scores.Average());
        }
    }
}