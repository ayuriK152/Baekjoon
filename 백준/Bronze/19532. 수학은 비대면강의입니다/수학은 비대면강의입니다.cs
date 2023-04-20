using System;

namespace AlgorithmStudy
{
    class boj19532
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]),
                b = int.Parse(input[1]),
                c = int.Parse(input[2]),
                d = int.Parse(input[3]),
                e = int.Parse(input[4]),
                f = int.Parse(input[5]);

            int eqA = -(a * e), eqB = c * e, eqC = -(d * b), eqD = f * b;
            int x = 0, y = 0;
            for (int i = -999; i <= 999; i++)
            {
                if (eqA * i + eqB == eqC * i + eqD)
                {
                    x = i;
                    if (b != 0)
                        y = (-(a * x) + c) / b;
                    else
                        y = (-(d * x) + f) / e;
                    break;
                }
            }
            Console.WriteLine(x + " " + y);
        }
    }
}
