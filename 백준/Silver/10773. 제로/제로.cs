using System;
using System.Collections;

namespace AlgorithmStudy
{
    class boj10773
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            int k = int.Parse(Console.ReadLine());
            int input;
            Int64 result = 0;
            for (int i = 0; i < k; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                    stack.Pop();
                else
                    stack.Push(input);
            }
            while(stack.Count > 0)
                result += (int)stack.Pop();
            Console.WriteLine(result);
        }
    }
}
