using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj11399
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(sr.ReadLine());
            int[] arr = new int[n];
            string[] input = sr.ReadLine().Split();
            sr.Close();
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(input[i]);
            Array.Sort(arr);
            for (int i = 1; i < n; i++)
                arr[i] += arr[i - 1];
            int result = 0;
            foreach (int i in arr)
                result += i;
            Console.WriteLine(result);
        }
    }
}
