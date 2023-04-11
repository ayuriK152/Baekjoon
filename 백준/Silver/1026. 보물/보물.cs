using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj1026
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(sr.ReadLine());
            int[] arrA = new int[n];
            int[] arrB = new int[n];
            string[] strA = sr.ReadLine().Split();
            string[] strB = sr.ReadLine().Split();
            sr.Close();
            for (int i = 0; i < n; i++)
            {
                arrA[i] = int.Parse(strA[i]);
                arrB[i] = int.Parse(strB[i]);
            }
            Array.Sort(arrA);
            Array.Sort(arrB);

            int result = 0;
            for (int i = 0; i < n; i++)
                result += arrA[i] * arrB[n - i - 1];

            Console.WriteLine(result);
        }
    }
}
