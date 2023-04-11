using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj1417
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(sr.ReadLine());
            int[] votes = new int[n - 1];
            int target = int.Parse(sr.ReadLine());
            for (int i = 0; i < n - 1; i++)
                votes[i] = int.Parse(sr.ReadLine());
            sr.Close();
            int count = 0;
            if (n != 1)
            {
                Array.Sort(votes);
                while (target <= votes[votes.Length - 1])
                {
                    count++;
                    votes[votes.Length - 1]--;
                    target++;
                    Array.Sort(votes);
                }
            }
            Console.WriteLine(count);
        }
    }
}
