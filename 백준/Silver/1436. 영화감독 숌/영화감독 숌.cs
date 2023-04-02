using System;
using System.Security.Policy;

namespace AlgorithmStudy
{
    class boj1436
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int flag = 0, title = 0;
            while (n != flag)
            {
                title++;
                string temp = title.ToString();
                int streak = 0;
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].Equals('6'))
                        streak++;
                    else
                        streak = 0;
                    if (streak == 3)
                    {
                        flag++;
                        break;
                    }
                }
            }
            Console.WriteLine(title);
        }
    }
}