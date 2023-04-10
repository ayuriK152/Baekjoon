using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj10989
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int[] counting = new int[10000];
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
                counting[short.Parse(sr.ReadLine()) - 1]++;
            for (short i = 0; i < 10000; i++)
                if (counting[i] != 0)
                    for (int j = 0; j < counting[i]; j++)
                        sw.WriteLine(i + 1);
            sw.Close();
            sr.Close();
        }
    }
}
