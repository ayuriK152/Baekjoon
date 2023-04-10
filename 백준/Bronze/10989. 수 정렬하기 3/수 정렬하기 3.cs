using System;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj10989
    {
        public static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int[] counting = new int[10000];
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                counting[short.Parse(Console.ReadLine()) - 1]++;
            StringBuilder sb = new StringBuilder();
            for (short i = 0; i < 10000; i++)
                if (counting[i] != 0)
                    for (int j = 0; j < counting[i]; j++)
                        sw.WriteLine(i + 1);
            sw.Close();
        }
    }
}
