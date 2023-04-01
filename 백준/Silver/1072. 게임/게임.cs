using System;

namespace AlgorithmStudy
{
    class boj1072
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            Int64 x = int.Parse(temp[0]), y = int.Parse(temp[1]);
            int z = (int)((Int64)(y * 100) / (double)x);
            if (z >= 99)
                Console.WriteLine("-1");
            else
                Console.WriteLine(ParametricSearch(1, x, z));
            Console.ReadLine();

            Int64 ParametricSearch(Int64 start, Int64 end, int target)
            {
                Int64 mid = (start + end) / 2;
                if (start == mid || mid == end)
                    if (Calc(target, start))
                        return start;
                    else
                        return end;
                if (Calc(target, mid))
                    return ParametricSearch(start, mid, target);
                else
                    return ParametricSearch(mid, end, target);
            }

            bool Calc(int target, Int64 value)
            {
                int result = (int)((Int64)((y + value) * 100) / (double)(x + value));
                if (result == target)
                    return false;
                else
                    return true;
            }
        }
    }
}