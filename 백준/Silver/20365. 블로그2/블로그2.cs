using System;

namespace AlgorithmStudy
{
    class boj20365
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] count = new int[2];
            if (input[0].Equals('B'))
                count[0]++;
            else
                count[1]++;
            for (int i = 1; i < n; i++)
            {
                if (input[i].Equals('B') && !input[i - 1].Equals('B'))
                    count[0]++;
                else if (input[i].Equals('R') && !input[i - 1].Equals('R'))
                    count[1]++;
            }
            int total = count[0] > count[1] ? count[1] + 1 : count[0] + 1;
            Console.WriteLine(total);
        }
    }
}
