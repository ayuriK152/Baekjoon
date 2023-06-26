using System;

namespace AlgorithmStudy
{
    class boj1002
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int x1 = int.Parse(input[0]), y1 = int.Parse(input[1]), r1 = int.Parse(input[2]), x2 = int.Parse(input[3]), y2 = int.Parse(input[4]), r2 = int.Parse(input[5]);
                int len = (int)(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                if (x1 == x2 && y1 == y2)
                {
                    if (r1 == r2)
                        Console.WriteLine("-1");
                    else
                        Console.WriteLine("0");
                }
                else
                {
                    if (len == Math.Pow(r1 + r2, 2) || (r1 > r2 ? Math.Pow(r1 - r2, 2) : Math.Pow(r2 - r1, 2)) == len)
                        Console.WriteLine("1");
                    else if (len > Math.Pow(r1 + r2, 2) || (r1 > r2 ? Math.Pow(r1 - r2, 2) : Math.Pow(r2 - r1, 2)) > len)
                        Console.WriteLine("0");
                    else if (len < Math.Pow(r1 + r2, 2))
                        Console.WriteLine("2");
                }
            }
        }
    }
}
