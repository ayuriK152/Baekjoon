using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj11758
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int[] x = new int[3];
            int[] y = new int[3];
            int alpha;

            string[] input;
            for (int i = 0; i < 3; i++)
            {
                input = sr.ReadLine().Split();
                x[i] = int.Parse(input[0]);
                y[i] = int.Parse(input[1]);
            }
            sr.Close();

            alpha = (y[0] * (x[1] - x[0])) - (x[0] * (y[1] - y[0]));
            int result = (x[2] * (y[1] - y[0])) - (y[2] * (x[1] - x[0])) + alpha;
            if (result == 0)
                Console.WriteLine("0");
            else if (result < 0)
                Console.WriteLine("1");
            else
                Console.WriteLine("-1");
        }
    }
}
