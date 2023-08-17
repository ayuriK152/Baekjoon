using System;

namespace AlgorithmStudy
{
    class boj1783
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int result = 1;
            if (n == 2)
                result += (m - 1) / 2 > 3 ? 3 : (m - 1) / 2;
            else if (n >= 3)
            {
                if (m >= 7)
                    result += m - 3;
                else
                    result += m >= 4 ? 3 : m - 1;
            }

            Console.WriteLine(result);
        }
    }
}
