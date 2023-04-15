using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj2166
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(sr.ReadLine());
            int[] x = new int[n];
            int[] y = new int[n];
            string[] input;
            for (int i = 0; i < n; i++)
            {
                input = sr.ReadLine().Split();
                x[i] = int.Parse(input[0]);
                y[i] = int.Parse(input[1]);
            }
            sr.Close();

            double totalArea = 0;
            long tempTotal = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                    tempTotal += (long)x[i] * y[0] - (long)x[0] * y[i];
                else
                    tempTotal += (long)x[i] * y[i + 1] - (long)x[i + 1] * y[i];
            }
            totalArea = (double)Math.Abs(tempTotal) / 2;

            Console.WriteLine(totalArea.ToString("F1"));
        }
    }
}
