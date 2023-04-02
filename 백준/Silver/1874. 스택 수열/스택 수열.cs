using System;
using System.Collections;
using System.Text;

namespace AlgorithmStudy
{
    class boj1874
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Stack stack = new Stack();
            StringBuilder result = new StringBuilder();
            int current = 1, index = 0;
            while (current <= n || stack.Count > 0)
            {
                if (stack.Count == 0)
                {
                    stack.Push(current++);
                    result.AppendLine("+");
                    continue;
                }
                if ((int)stack.Peek() == arr[index])
                {
                    stack.Pop();
                    result.AppendLine("-");
                    index++;
                }
                else if (current > n)
                {
                    Console.WriteLine("NO");
                    break;
                }
                else
                {
                    stack.Push(current++);
                    result.AppendLine("+");
                }
            }
            if (index == n)
                Console.WriteLine(result);
        }
    }
}