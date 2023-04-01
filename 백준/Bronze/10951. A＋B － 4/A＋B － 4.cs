using System;

namespace AlgorithmStudy
{
    class boj10951
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null)
                    break;
                string[] temp = input.Split();
                Console.WriteLine(int.Parse(temp[0]) + int.Parse(temp[1]));
            }
        }
    }
}