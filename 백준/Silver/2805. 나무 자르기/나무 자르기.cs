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

            long ParametricSearch(long start, long end, int[] arr, int target)  // 이분 탐색용 메소드
            {
                long mid = (start + end) / 2;
                if (start == mid || mid == end)     // 최소값과 최대값 중 어떤 쪽이 답인지 판단하는 조건문
                    if (Calc(arr, target, end))
                        return end;
                    else
                        return start;
                if (Calc(arr, target, mid))
                    return ParametricSearch(mid, end, arr, target);
                else
                    return ParametricSearch(start, mid, arr, target);
            }

            bool Calc(int[] arr, int target, long value)    // 절단기 설정 값에 따른 결과값, 이분 탐색을 통해 넘겨받은 설정값을 기준으로 나뭇가지들을 자른 나머지를 구함
            {
                long sum = 0;
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