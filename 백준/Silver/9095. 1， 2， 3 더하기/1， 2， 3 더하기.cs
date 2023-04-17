using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj9095
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int[] factorials = new int[11];
            factorials[0] = 1;
            factorials[1] = 1;
            for (int i = 2; i < 11; i++)
                factorials[i] = i * factorials[i - 1];
            int t = int.Parse(sr.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int[] numCount = new int[3];
                int n = int.Parse(sr.ReadLine());
                int temp = n;
                numCount[2] = temp / 3;

                int count = 0;
                for (int a = numCount[2]; a >= 0; a--)
                {
                    temp = n;
                    temp -= 3 * a;
                    numCount[1] = temp / 2;
                    temp %= 2;
                    numCount[0] = temp;
                    for (int b = numCount[1]; b >= 0; b--)
                    {
                        count += factorials[a + b + numCount[0]] / (factorials[a] * factorials[b] * factorials[numCount[0]]);
                        numCount[0] += 2;
                    }
                }

                Console.WriteLine(count);
            }
            sr.Close();
        }
    }
}
