using System;
using System.Linq;

namespace AlgorithmStudy
{
    class boj1654
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int k = int.Parse(temp[0]), n = int.Parse(temp[1]);
            int[] lan = new int[k];
            for (int i = 0; i < k; i++)
            {
                lan[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(ParametricSearch(1, lan.Max(), lan, n));
            Console.ReadLine();

            Int64 ParametricSearch(Int64 start, Int64 end, int[] arr, int count)
            {
                Int64 mid = (start + end) / 2;
                if (!Calc(arr, mid, count))
                    return ParametricSearch(start, mid, arr, count);
                else if (Calc(arr, mid, count) && (start == mid || mid == end))
                    if (Calc(arr, end, count))
                        return end;
                    else
                        return start;
                else
                    return ParametricSearch(mid, end, arr, count);
            }

            bool Calc(int[] arr, Int64 value, int count)
            {
                Int64 sum = 0;
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i] / value;

                if (sum < count)
                    return false;
                else
                    return true;
            }
        }
    }
}