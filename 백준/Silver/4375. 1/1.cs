using System;

namespace AlgorithmStudy
{
    class boj10811
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string temp = Console.ReadLine();
                if (temp == null)
                    break;
                int input = int.Parse(temp);
                int target = 1, count = 1;
                bool flag = true;
                while (flag)
                {
                    flag = false;
                    if (target % input != 0)
                    {
                        count++;
                        target *= 10;
                        target += 1;
                        target %= input;
                        flag = true;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
