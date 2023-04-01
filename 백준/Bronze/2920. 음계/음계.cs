using System;

namespace AlgorithmStudy
{
    class boj2920
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            bool asc = true, des = true;
            for (int i = 0; i < 8; i++)
            {
                if (int.Parse(temp[i]) != i + 1)
                    asc = false;
                if (int.Parse(temp[i]) != 8 - i)
                    des = false;
            }
            if (asc)
                Console.WriteLine("ascending");
            else if (des)
                Console.WriteLine("descending");
            else
                Console.WriteLine("mixed");
            Console.ReadLine();
        }
    }
}