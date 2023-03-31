using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj1920
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] nums = new int[count];
            string[] temp = Console.ReadLine().Split();
            for (int i = 0; i < count; i++)
                nums[i] = int.Parse(temp[i]);

            Array.Sort(nums);

            count = int.Parse(Console.ReadLine());
            int[] targets = new int[count];
            StringBuilder result = new StringBuilder();
            temp = Console.ReadLine().Split();
            for (int i = 0; i < count; i++)
                targets[i] = int.Parse(temp[i]);

            for (int i = 0; i < count; i++)
            {
                if (Array.BinarySearch(nums, targets[i]) < 0)
                    if (count - 1 == i)
                        result.Append("0");
                    else
                        result.AppendLine("0");
                else
                    if (count - 1 == i)
                    result.Append("1");
                else
                    result.AppendLine("1");
            }
            Console.WriteLine(result);
        }
    }
}