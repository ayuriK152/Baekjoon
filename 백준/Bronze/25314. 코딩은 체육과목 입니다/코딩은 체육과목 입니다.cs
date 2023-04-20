using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj25314
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n / 4; i++)
                sb.Append("long ");
            sb.Append("int");
            Console.WriteLine(sb);
        }
    }
}
