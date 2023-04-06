using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj10871
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] temp = Console.ReadLine().Split();
            int n = int.Parse(temp[0]), x = int.Parse(temp[1]);
            temp = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(temp[i]) < x)
                    sb.Append(temp[i] + " ");
            }
            Console.WriteLine(sb);
        }
    }
}