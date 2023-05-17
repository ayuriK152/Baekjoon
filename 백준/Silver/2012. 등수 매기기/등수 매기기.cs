using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj2012
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(sr.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(sr.ReadLine());
            Array.Sort(arr);
            long total = 0;
            for (int i = 0; i < n; i++)
                total += Math.Abs(arr[i] - (i + 1));
            sr.Close();
            Console.WriteLine(total);
        }
    }
}
