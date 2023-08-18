using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj21314
    {
        public static void Main(string[] args)
        {
            StringBuilder max = new StringBuilder();
            StringBuilder min = new StringBuilder();
            string[] input = Console.ReadLine().Split('K');

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    if (input[i] != "")
                    {
                        for (int j = 0; j < input[i].Length; j++)
                            max.Append(1);
                    }
                    else
                        max.Append(5);
                }
                else
                {
                    max.Append(5);
                    for (int j = 0; j < input[i].Length; j++)
                        max.Append(0);

                    if (i == input.Length - 2 && input[input.Length - 1] == "")
                        break;
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != "")
                {
                    min.Append(1);
                    for (int j = 0; j < input[i].Length - 1; j++)
                        min.Append(0);
                }
                if (i < input.Length - 1)
                    min.Append(5);
            }

            Console.Write($"{max}\n{min}");
        }
    }
}
