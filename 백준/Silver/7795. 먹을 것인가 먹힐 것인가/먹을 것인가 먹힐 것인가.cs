using System;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj7795
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]), m = int.Parse(input[1]);
                int[] a = new int[n];
                int[] b = new int[m];

                input = Console.ReadLine().Split(' ');
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(input[i]);

                input = Console.ReadLine().Split(' ');
                for (int i = 0; i < m; i++)
                    b[i] = int.Parse(input[i]);
                Array.Sort(a);
                Array.Sort(b);

                int pivotN = 0, pivotM = 0, count = 0;
                while (pivotN < n && pivotM < m)
                {
                    if (a[pivotN] > b[pivotM])
                    {
                        if (pivotM < m - 1)
                        {
                            pivotM++;
                            continue;
                        }
                        else
                            count += pivotM + 1;
                    }
                    else if (a[pivotN] <= b[pivotM])
                    {
                        count += pivotM;
                    }
                    pivotN++;
                }
                sb.AppendLine(count.ToString());
                t--;
            }
            Console.WriteLine(sb);
        }
    }
}
