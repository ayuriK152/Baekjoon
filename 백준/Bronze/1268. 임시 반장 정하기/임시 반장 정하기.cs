using System;
using System.Linq;

namespace AlgorithmStudy
{
    class boj1268
    {
        public static void Main(string[] args)
        {
            int stdCnt = int.Parse(Console.ReadLine());
            int[,] students = new int[stdCnt, 5];

            string input;
            for (int i = 0; i < stdCnt; i++)
            {
                input = Console.ReadLine();
                string[] classes = input.Split();
                for (int j = 0; j < 5; j++)
                    students[i, j] = int.Parse(classes[j]);
            }

            int[] sameCnt = new int[stdCnt];
            sameCnt.Initialize();

            for (int i = 0; i < stdCnt; i++)
            {
                for (int j = 0; j < stdCnt; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (students[i, k] == students[j, k] && i != j)
                        {
                            sameCnt[i] += 1;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(Array.IndexOf(sameCnt, sameCnt.Max()) + 1);
        }
    }
}