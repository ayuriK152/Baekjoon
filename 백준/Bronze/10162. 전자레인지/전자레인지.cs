using System;

namespace AlgorithmStudy
{
    class boj10162
    {
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            if (t % 10 == 0)
            {
                int result = -1;
                int[] count = new int[3];
                result = 0;
                count[0] = t / 300;
                t = t % 300;
                count[1] = t / 60;
                t = t % 60;
                count[2] = t / 10;
                Console.WriteLine(count[0] + " " + count[1] + " " + count[2]);
            }
            else
                Console.WriteLine("-1");
        }
    }
}
