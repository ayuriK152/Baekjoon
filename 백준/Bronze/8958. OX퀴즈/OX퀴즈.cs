using System;

namespace AlgorithmStudy
{
    class boj8958
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] scores = new int[n];
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                int streak = 0;
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j].Equals('O'))
                    {
                        streak++;
                        scores[i] += streak;
                    }
                    else
                        streak = 0;
                }
            }
            foreach(int i in scores)
                Console.WriteLine(i);
        }
    }
}