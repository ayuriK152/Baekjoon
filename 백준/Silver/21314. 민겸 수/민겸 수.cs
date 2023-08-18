using System;

namespace AlgorithmStudy
{
    class boj21314
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('K');
            string max = "", min = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 2 && input[input.Length - 1] == "")
                {
                    max += 5;
                    for (int j = 0; j < input[i].Length; j++)
                        max += 0;
                    break;
                }

                if (i == input.Length - 1)
                {
                    if (input[i] != "")
                    {
                        for (int j = 0; j < input[i].Length; j++)
                            max += 1;
                    }
                    else
                        max += 5;
                }
                else
                {
                    max += (Math.Pow(10, input[i].Length) * 5).ToString();
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != "")
                {
                    min += 1;
                    for (int j = 0; j < input[i].Length - 1; j++)
                        min += 0;
                }
                if (i < input.Length - 1)
                    min += 5;
            }

            Console.WriteLine($"{max}\n{min}");
        }
    }
}
