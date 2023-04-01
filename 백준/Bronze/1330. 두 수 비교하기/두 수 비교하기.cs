using System;

namespace AlgorithmStudy
{
    class boj1330
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int a = int.Parse(temp[0]), b = int.Parse(temp[1]);
            if (a > b)
                Console.WriteLine(">");
            else if (a < b)
                Console.WriteLine("<");
            else
                Console.WriteLine("==");
        }
    }
}
