using System;
using System.Linq;

namespace AlgorithmStudy
{
    class boj4153
    {
        public static void Main(string[] args)
        {
            string[] temp;
            int[] lines = new int[3];
            while (true)
            {
                int total = 0;
                temp = Console.ReadLine().Split();
                for (int i = 0; i < 3; i++)
                    lines[i] = int.Parse(temp[i]);
                if (lines.Max() == 0)
                    break;

                for (int i = 0; i < 3; i++)
                    if (lines[i] == lines.Max())
                        total += lines[i] * lines[i];
                    else
                        total -= lines[i] * lines[i];
                if (total == 0)
                    Console.WriteLine("right");
                else
                    Console.WriteLine("wrong");
            }
        }
    }
}
