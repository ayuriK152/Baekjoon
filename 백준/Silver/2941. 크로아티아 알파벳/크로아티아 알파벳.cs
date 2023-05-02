using System;

namespace AlgorithmStudy
{
    class boj2941
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int total = input.Length;
            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - 1)
                {
                    if (input[i].Equals('c'))
                    {
                        if (input[i + 1].Equals('=') || input[i + 1].Equals('-'))
                        {
                            total -= 1;
                            i += 1;
                        }
                    }
                    else if (input[i].Equals('d'))
                    {
                        if (i < input.Length - 2 && input[i + 1].Equals('z'))
                        {
                            if (input[i + 2].Equals('='))
                            {
                                total -= 2;
                                i += 2;
                            }
                        }
                        else if (input[i + 1].Equals('-'))
                        {
                            total -= 1;
                            i += 1;
                        }
                    }
                    else if (input[i].Equals('l'))
                    {

                        if (input[i + 1].Equals('j'))
                        {
                            total -= 1;
                            i += 1;
                        }
                    }
                    else if (input[i].Equals('n'))
                    {
                        if (input[i + 1].Equals('j'))
                        {
                            total -= 1;
                            i += 1;
                        }
                    }
                    else if (input[i].Equals('s') || input[i].Equals('z'))
                    {
                        if (input[i + 1].Equals('='))
                        {
                            total -= 1;
                            i += 1;
                        }
                    }
                }
            }
            Console.WriteLine(total);
        }
    }
}
