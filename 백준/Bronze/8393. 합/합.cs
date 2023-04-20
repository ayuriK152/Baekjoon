using System;

namespace AlgorithmStudy
{
    class boj8393
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            if (n == 1)
                result = 1;
            else
            {
                result = (n + 1) * (n / 2);
                if (n % 2 == 1)
                    result += n / 2 + 1;
            }

            Console.WriteLine(result);
        }
    }
}
