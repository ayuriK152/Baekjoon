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

            long ParametricSearch(long start, long end, int[] arr, int count)
            {
                long mid = (start + end) / 2;
                bool calcResult = Calc(arr, mid, count);
                if (!calcResult)
                    return ParametricSearch(start, mid, arr, count);
                else if (calcResult && (start == mid || mid == end))
                    if (Calc(arr, end, count))
                        return end;
                    else
                        return start;
                else
                    return ParametricSearch(mid, end, arr, count);
            }

            bool Calc(int[] arr, long value, int count)
            {
                long sum = 0;
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
