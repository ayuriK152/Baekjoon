using System;
using System.Linq;

namespace AlgorithmStudy
{
    class boj1463
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dp = new int[1000001];
            dp[1] = 0; dp[2] = 1; dp[3] = 1;
            Console.WriteLine(Calc(n));

            int Calc(int _num)
            {
                if (_num == 1) return 0;
                if (_num == 2) return 1;
                if (_num == 3) return 1;

                if (dp[_num] == 0)
                {
                    if (_num % 2 != 0 && _num % 3 != 0)
                        dp[_num] = Calc(_num - 1) + 1;
                    else if (_num % 2 == 0 && _num % 3 == 0)
                        dp[_num] = Calc(_num / 2) > Calc(_num / 3) ? Calc(_num / 3) + 1 : Calc(_num / 2) + 1;
                    else if (_num % 2 == 0 && _num % 3 != 0)
                        dp[_num] = Calc(_num / 2) > Calc(_num - 1) ? Calc(_num - 1) + 1 : Calc(_num / 2) + 1;
                    else if (_num % 2 != 0 && _num % 3 == 0)
                        dp[_num] = Calc(_num / 3) > Calc(_num - 1) ? Calc(_num - 1) + 1 : Calc(_num / 3) + 1;
                }

                return dp[_num];
            }
        }
    }
}