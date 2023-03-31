using System;

namespace AlgorithmStudy
{
    class boj11382
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Int64 result = Int64.Parse(input[0]) + Int64.Parse(input[1]) + Int64.Parse(input[2]);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}