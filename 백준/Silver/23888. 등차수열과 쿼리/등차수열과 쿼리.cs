using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj23888
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            string[] input = sr.ReadLine().Split();
            int a = int.Parse(input[0]), d = int.Parse(input[1]);
            int q = int.Parse(sr.ReadLine());
            for (int i = 0; i < q; i++)
            {
                input = sr.ReadLine().Split();
                int l = int.Parse(input[1]), r = int.Parse(input[2]);
                int start = a + (l - 1) * d;
                if (int.Parse(input[0]) == 1)
                {
                    int result = (r - l + 1) * (start + (a + d * (r - 1))) / 2;
                    Console.WriteLine(result);
                }
                else
                {
                    if (l == r)
                        Console.WriteLine(start);
                    else
                        Console.WriteLine(GCD(start, d));
                }
            }
            sr.Close();

            int GCD(int min, int max)
            {
                if (max % min == 0)
                    return min;
                else
                    return GCD(max % min, min);
            }
        }
    }
}
