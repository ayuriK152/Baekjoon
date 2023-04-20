using System;

namespace AlgorithmStudy
{
    class boj2480
    {
        public static void Main(string[] args)
        {
            int[] dices = new int[6];
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);
            dices[a - 1]++;
            dices[b - 1]++;
            dices[c - 1]++;
            int max = 0, result = 0;
            for (int i = 0; i < 6; i++)
            {
                if (dices[i] == 1)
                    max = i + 1;
                else if (dices[i] == 2)
                {
                    result = 1000 + (i + 1) * 100;
                    break;
                }
                else if (dices[i] == 3)
                {
                    result = 10000 + (i + 1) * 1000;
                    break;
                }
            }
            if (result != 0)
                Console.WriteLine(result);
            else
                Console.WriteLine(max * 100);
        }
    }
}
