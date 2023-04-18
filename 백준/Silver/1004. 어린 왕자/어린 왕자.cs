using System;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj1004
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(sr.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] input = sr.ReadLine().Split();
                int x1 = int.Parse(input[0]), y1 = int.Parse(input[1]), x2 = int.Parse(input[2]), y2 = int.Parse(input[3]);

                int n = int.Parse(sr.ReadLine());
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    input = sr.ReadLine().Split();
                    int xc = int.Parse(input[0]), yc = int.Parse(input[1]), r = int.Parse(input[2]);
                    if (Math.Pow(x1 - xc, 2) + Math.Pow(y1 - yc, 2) - Math.Pow(r, 2) < 0 && Math.Pow(x2 - xc, 2) + Math.Pow(y2 - yc, 2) - Math.Pow(r, 2) > 0)
                        count++;
                    else if (Math.Pow(x2 - xc, 2) + Math.Pow(y2 - yc, 2) - Math.Pow(r, 2) < 0 && Math.Pow(x1 - xc, 2) + Math.Pow(y1 - yc, 2) - Math.Pow(r, 2) > 0)
                        count++;
                }
                sb.AppendLine(count.ToString());
            }
            sr.Close();
            Console.WriteLine(sb);
        }
    }
}
