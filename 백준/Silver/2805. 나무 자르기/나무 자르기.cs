using System;
using System.Linq;

namespace AlgorithmStudy
{
    class boj2805
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int n = int.Parse(temp[0]), k = int.Parse(temp[1]);
            int[] len = new int[n];
            temp = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
                len[i] = int.Parse(temp[i]);
            Console.WriteLine(ParametricSearch(0, len.Max(), len, k));
            Console.ReadLine();

            Int64 ParametricSearch(Int64 start, Int64 end, int[] arr, int target)
            {
                Int64 mid = (start + end) / 2;
                if (start == mid || mid == end)
                    if (Calc(arr, target, end))
                        return end;
                    else
                        return start;
                if (Calc(arr, target, mid))
                    return ParametricSearch(mid, end, arr, target);
                else
                    return ParametricSearch(start, mid, arr, target);
            }

            bool Calc(int[] arr, int target, Int64 value)
            {
                Int64 sum = 0;
                for (int i = 0; i < arr.Length; i++)
                    if (value < arr[i])
                        sum += arr[i] - value;
                if (sum < target)
                    return false;
                else
                    return true;
            }
        }
    }
}