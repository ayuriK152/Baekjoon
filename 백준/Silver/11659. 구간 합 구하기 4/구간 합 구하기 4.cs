using System;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj11659
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StringBuilder sb = new StringBuilder();
            string[] input = sr.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int[] arr = new int[n + 1];
            input = sr.ReadLine().Split();
            arr[1] = int.Parse(input[0]);
            for (int i = 2; i <= n; i++)
                arr[i] = arr[i - 1] + int.Parse(input[i - 1]);
            for (int i = 0; i < m; i++)
            {
                input = sr.ReadLine().Split();
                sb.AppendLine((arr[int.Parse(input[1])] - arr[int.Parse(input[0]) - 1]).ToString());
            }
            sr.Close();
            Console.Write(sb);
        }
    }
}
