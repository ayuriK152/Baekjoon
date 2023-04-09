using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj10866
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            Deque deque = new Deque();
            int n = int.Parse(sr.ReadLine());
            string[] input;

            for (int i = 0; i < n; i++)
            {
                input = sr.ReadLine().Split();
                switch (input[0])
                {
                    case "push_front":
                        deque.PushFront(int.Parse(input[1]));
                        break;
                    case "push_back":
                        deque.PushLast(int.Parse(input[1]));
                        break;
                    case "pop_front":
                        sb.Append(deque.PopFront());
                        Console.WriteLine(sb);
                        sb.Clear();
                        break;
                    case "pop_back":
                        sb.Append(deque.PopLast());
                        Console.WriteLine(sb);
                        sb.Clear();
                        break;
                    case "size":
                        sb.Append(deque.Size());
                        Console.WriteLine(sb);
                        sb.Clear();
                        break;
                    case "empty":
                        sb.Append(deque.IsEmpty());
                        Console.WriteLine(sb);
                        sb.Clear();
                        break;
                    case "front":
                        sb.Append(deque.Front());
                        Console.WriteLine(sb);
                        sb.Clear();
                        break;
                    case "back":
                        sb.Append(deque.Last());
                        Console.WriteLine(sb);
                        sb.Clear();
                        break;
                }
            }
        }

        class Deque
        {
            Node first, last;
            int count;

            public Deque()
            {
                count = 0;
            }

            public void PushFront(int value)
            {
                Node n = new Node(value);
                if (count == 0)
                    first = last = n;
                else
                {
                    first.prev = n;
                    n.next = first;
                    first = n;
                }
                count++;
            }

            public void PushLast(int value)
            {
                Node n = new Node(value);
                if (count == 0)
                    first = last = n;
                else
                {
                    last.next = n;
                    n.prev = last;
                    last = n;
                }
                count++;
            }

            public int PopFront()
            {
                if (count == 0)
                    return -1;
                int temp = first.value;
                if (count-- > 1)
                {
                    first = first.next;
                    first.prev.next = null;
                    first.prev = null;
                    return temp;
                }
                else
                {
                    last = first = null;
                    return temp;
                }
            }

            public int PopLast()
            {
                if (count == 0)
                    return -1;
                int temp = last.value;
                if (count-- > 1)
                {
                    last = last.prev;
                    last.next.prev = null;
                    last.next = null;
                    return temp;
                }
                else
                {
                    last = first = null;
                    return temp;
                }
            }

            public int Size()
            {
                return count;
            }

            public int IsEmpty()
            {
                if (count == 0)
                    return 1;
                else
                    return 0;
            }

            public int Front()
            {
                if (count == 0)
                    return -1;
                return first.value;
            }

            public int Last()
            {
                if (count == 0)
                    return -1;
                return last.value;
            }
        }

        class Node
        {
            public Node next, prev;
            public int value;

            public Node(int _value)
            {
                value = _value;
                next = prev = null;
            }
        }
    }
}
