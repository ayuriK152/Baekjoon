using System;
using System.Linq;

namespace AlgorithmStudy
{
    class boj1439
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] zeroSeparator = new char[] { '0' }, firstSeparator = new char[] { '1' };
            int n = input.Split(zeroSeparator, StringSplitOptions.RemoveEmptyEntries).Count(), m = input.Split(firstSeparator, StringSplitOptions.RemoveEmptyEntries).Count();
            if (n > m)
                Console.WriteLine(m);
            else
                Console.WriteLine(n);
        }
    }
}
