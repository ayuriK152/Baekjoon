using System;
using System.Runtime.InteropServices;

namespace AlgorithmStudy
{
    class boj2525
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]), b = int.Parse(input[1]);
            int c = int.Parse(Console.ReadLine());
            int resultM = b + (c % 60);
            int resultH;
            if (resultM >= 60)
            {
                resultM -= 60;
                resultH = ((a + c / 60) + 1) % 24;
            }
            else
                resultH = (a + c / 60) % 24;

            Console.WriteLine(resultH + " " + resultM);
        }
    }
}
