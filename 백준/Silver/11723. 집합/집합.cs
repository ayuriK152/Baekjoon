using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj11723
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            bool[] sets = new bool[20];
            int m = int.Parse(sr.ReadLine());
            for (; m > 0; m--)
            {
                string[] input = sr.ReadLine().Split();
                switch (input[0])
                {
                    case "add":
                        sets[short.Parse(input[1]) - 1] = true;
                        break;
                    case "remove":
                        sets[short.Parse(input[1]) - 1] = false;
                        break;
                    case "check":
                        if (sets[short.Parse(input[1]) - 1])
                            sw.WriteLine("1");
                        else
                            sw.WriteLine("0");
                        break;
                    case "toggle":
                        sets[short.Parse(input[1]) - 1] = !sets[short.Parse(input[1]) - 1];
                        break;
                    case "all":
                        for (short i = 0; i < 20; i++)
                            sets[i] = true;
                        break;
                    case "empty":
                        for (short i = 0; i < 20; i++)
                            sets[i] = false;
                        break;
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}
