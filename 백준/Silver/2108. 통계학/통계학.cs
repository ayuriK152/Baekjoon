using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmStudy
{
    class boj2108
    {
        public static void Main(string[] args)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] result = new int[4];
            int cnt = int.Parse(Console.ReadLine());
            int[] nums = new int[cnt];
            for (int i = 0; i < cnt; i++)
                nums[i] = int.Parse(Console.ReadLine());

            Array.Sort(nums);
            for (int i = 0; i < cnt; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]]++;
                else
                    dic.Add(nums[i], 1);
            }

            int total = 0;
            bool isNegative = false;
            foreach (int i in nums)
                total += i;
            if (total < 0)
            {
                total = -total;
                isNegative = true;
            }
            double tempD = (double)total / cnt;
            if (tempD >= (int)tempD + 0.5)
                result[0] = (int)tempD + 1;
            else
                result[0] = (int)tempD;
            if (isNegative)
                result[0] = -result[0];

            if (cnt % 2 == 1)
                result[1] = nums[cnt / 2];
            else
                result[1] = nums[cnt / 2] - 1;

            int temp = 0;
            int maxVal = dic.Values.Max();
            bool isChanged = false;
            foreach (int i in dic.Keys)
            {
                if (dic[i].Equals(dic.Values.Max()))
                {
                    temp = i;
                    if (isChanged)
                        break;
                    else
                        isChanged = true;
                }
            }
            result[2] = temp;

            result[3] = Math.Abs(nums.Max() - nums.Min());

            foreach(int i in result)
                Console.WriteLine(i);
        }
    }
}