using System;
using System.Collections;
using System.Text;

namespace AlgorithmStudy
{
    class boj4949
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                sb.Append(Console.ReadLine());
                if (sb[0].Equals('.') && sb.Length == 1)
                    break;
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i].Equals('(') || sb[i].Equals('['))
                        stack.Push(sb[i]);
                    if (sb[i].Equals(')'))
                    {
                        if (stack.Count > 0)
                        {
                            if (stack.Peek().Equals('('))
                                stack.Pop();
                            else
                                stack.Push(sb[i]);
                        }
                        else
                            stack.Push(sb[i]);
                    }
                    if (sb[i].Equals(']'))
                    {
                        if (stack.Count > 0)
                        {
                            if (stack.Peek().Equals('['))
                                stack.Pop();
                            else
                                stack.Push(sb[i]);
                        }
                        else
                            stack.Push(sb[i]);
                    }
                }
                if (stack.Count == 0)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
                stack.Clear();
                sb.Clear();
            }
        }
    }
}
