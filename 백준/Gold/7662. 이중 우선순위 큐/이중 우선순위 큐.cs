using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj7662
    {
        public static void Main(string[] args)
        {
            PriorityDeque deque = new PriorityDeque();
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(sr.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int k = int.Parse(sr.ReadLine());
                for (int j = 0; j < k; j++)
                {
                    string[] input = sr.ReadLine().Split();
                    switch (input[0])
                    {
                        case "I":
                            deque.Add(int.Parse(input[1]));
                            break;
                        case "D":
                            if (int.Parse(input[1]) == -1)
                                deque.DeleteMin();
                            else
                                deque.DeleteMax();
                            break;
                    }
                }
                if (deque.IsEmpty())
                    sb.AppendLine("EMPTY");
                else
                    sb.AppendLine(deque.PeekMax() + " " + deque.PeekMin());
                deque.Clear();
            }
            sr.Close();
            Console.Write(sb);
        }

        class PriorityDeque
        {
            int[] elements;
            int pos;

            public PriorityDeque()
            {
                elements = new int[1000001];
                pos = 1;
            }

            public void Add(int n)
            {
                int current = pos++;
                elements[current] = n;

                if (current % 2 == 0)
                {
                    if (elements[current] < elements[current - 1])
                    {
                        int temp = elements[current];
                        elements[current] = elements[current - 1];
                        elements[current - 1] = temp;
                        current--;
                    }
                }

                int parent = (current - 1) / 2;
                int grandParent = (((current - 1) / 2) - 1) / 2;
                while (parent > 0)
                {
                    grandParent = (parent - 1) / 2;
                    if (n < elements[(grandParent + 1) * 2 - 1])
                    {
                        int temp = elements[current];
                        elements[current] = elements[(grandParent + 1) * 2 - 1];
                        elements[(grandParent + 1) * 2 - 1] = temp;
                        current = (grandParent + 1) * 2 - 1;
                        parent = (current - 1) / 2;
                    }

                    else if (n > elements[(grandParent + 1) * 2])
                    {
                        int temp = elements[current];
                        elements[current] = elements[(grandParent + 1) * 2];
                        elements[(grandParent + 1) * 2 ] = temp;
                        current = (grandParent + 1) * 2;
                        parent = (current - 1) / 2;
                    }

                    else
                        break;
                }
            }

            public void DeleteMin()
            {
                if (pos == 1)
                    return;
                pos--;
                elements[1] = elements[pos];

                int current = 1;
                while (true)
                {
                    if (current + 1 < pos)
                    {
                        if (elements[current] > elements[current + 1])
                        {
                            int temp = elements[current];
                            elements[current] = elements[current + 1];
                            elements[current + 1] = temp;
                        }
                    }

                    if ((current + 1) * 2 - 1 >= pos)
                        break;
                    if ((current + 1) * 2 + 1 >= pos)
                    {
                        if (elements[current] > elements[(current + 1) * 2 - 1])
                        {
                            int temp = elements[current];
                            elements[current] = elements[(current + 1) * 2 - 1];
                            elements[(current + 1) * 2 - 1] = temp;
                            current = (current + 1) * 2 - 1;
                        }
                        else
                            break;
                    }

                    else
                    {
                        int chPos = elements[(current + 1) * 2 - 1] > elements[(current + 1) * 2 + 1] ? (current + 1) * 2 + 1 : (current + 1) * 2 - 1;
                        if (elements[current] > elements[chPos])
                        {
                            int temp = elements[current];
                            elements[current] = elements[chPos];
                            elements[chPos] = temp;
                            current = chPos;
                        }
                        else
                            break;
                    }
                }
            }

            public void DeleteMax()
            {
                if (pos == 1)
                    return;
                pos--;
                elements[2] = elements[pos];

                int current = 2;
                while (true)
                {
                    if (elements[current] < elements[current - 1])
                    {
                        int temp = elements[current];
                        elements[current] = elements[current - 1];
                        elements[current - 1] = temp;
                    }

                    if ((current + 1) * 2 - 2 >= pos)
                        break;
                    if ((current + 1) * 2 >= pos)
                    {
                        if (elements[current] < elements[(current + 1) * 2 - 2])
                        {
                            int temp = elements[current];
                            elements[current] = elements[(current + 1) * 2 - 2];
                            elements[(current + 1) * 2 - 2] = temp;
                            current = (current + 1) * 2 - 2;
                        }
                        else
                            break;
                    }

                    else
                    {
                        int chPos = elements[(current + 1) * 2 - 2] > elements[(current + 1) * 2] ? (current + 1) * 2 - 2: (current + 1) * 2;
                        if (elements[current] < elements[chPos])
                        {
                            int temp = elements[current];
                            elements[current] = elements[chPos];
                            elements[chPos] = temp;
                            current = chPos;
                        }
                        else
                            break;
                    }
                }
            }

            public bool IsEmpty()
            {
                if (pos == 1)
                    return true;
                else
                    return false;
            }

            public int PeekMin()
            {
                return elements[1];
            }

            public int PeekMax()
            {
                if (pos == 2)
                    return elements[1];
                else
                    return elements[2];
            }

            public void Clear()
            {
                pos = 1;
            }
        }
    }
}
