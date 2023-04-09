using System;

namespace AlgorithmStudy
{
    class boj2231
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            for (int i = 1; i < n; i++)
            {
                int result = i, temp = i;
                for (int j = i.ToString().Length - 1; j >= 0; j--)
                {
                    result += temp / (int)Math.Pow(10, j);
                    temp -= (temp / (int)Math.Pow(10, j)) * (int)Math.Pow(10, j);
                }
                if (result == n)
                {
                    ans = i;
                    break;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
