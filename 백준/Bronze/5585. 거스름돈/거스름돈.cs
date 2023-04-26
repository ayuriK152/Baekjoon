using System;

namespace AlgorithmStudy
{
    class boj5585
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int remain = 1000 - n;
            int count = 0;
            count += remain / 500;
            remain = remain % 500;
            count += remain / 100;
            remain = remain % 100;
            count += remain / 50;
            remain = remain % 50;
            count += remain / 10;
            remain = remain % 10;
            count += remain / 5;
            remain = remain % 5;
            count += remain / 1;
            remain = remain % 1;
            Console.WriteLine(count);
        }
    }
}
