using System;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj5430
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(sr.ReadLine());
            for (int i = 0; i < t; i++)
            {
                Deque deque = new Deque();
                string command = sr.ReadLine();
                int n = int.Parse(sr.ReadLine()), commandLen = command.Length;
                string[] arrStr = sr.ReadLine().Remove(0, 1).Split(',');
                bool isErrorOccurred = false;
                for (int j = 0; j < n; j++)
                {
                    if (j == n - 1)
                        deque.Add(int.Parse(arrStr[j].Remove(arrStr[j].Length - 1, 1)));
                    else
                        deque.Add(int.Parse(arrStr[j]));
                }

                for (int j = 0; j < commandLen; j++)
                {
                    if (command[j].Equals('R'))
                        deque.Reverse();
                    else
                    {
                        if (!deque.Delete())
                        {
                            isErrorOccurred = true;
                            break;
                        }
                    }
                }

                if (isErrorOccurred)
                    Console.WriteLine("error");
                else
                {
                    sb.Append("[");
                    deque.ShowAll(sb);
                    sb.Append("]");
                    Console.WriteLine(sb);
                    sb.Clear();
                }
            }
            sr.Close();
        }

        class Deque
        {
            bool isReversed;
            int count;
            Elements first, last;

            public Deque()
            {
                count = 0;
                isReversed = false;
                first = last = null;
            }

            public void Add(int val)
            {
                Elements d = new Elements(val);
                if (count == 0)
                    first = last = d;
                else
                {
                    last.next = d;
                    d.prev = last;
                    last = d;
                }
                count++;
            }

            public void Reverse()
            {
                if (isReversed)
                    isReversed = false;
                else
                    isReversed = true;
            }

            public bool Delete()
            {
                if (count == 0)
                    return false;
                if (!isReversed)
                {
                    if (first != last)
                    {
                        first = first.next;
                        first.prev.next = null;
                        first.prev = null;
                    }
                    else
                        first = last = null;
                    count--;
                    return true;
                }
                else
                {
                    if (first != last)
                    {
                        last = last.prev;
                        last.next.prev = null;
                        last.next = null;
                    }
                    else
                        first = last = null;
                    count--;
                    return true;
                }
            }

            public void ShowAll(StringBuilder sb)
            {
                if (!isReversed)
                    Show(first, sb);
                else
                    Show(last, sb);
            }

            void Show(Elements e, StringBuilder sb)
            {
                if (first == null && last == null)
                    return;
                if (!isReversed)
                {
                    if (e.Equals(last))
                        sb.Append(e.value.ToString());
                    else
                    {
                        sb.Append(e.value.ToString() + ",");
                        Show(e.next, sb);
                    }
                }
                else
                {
                    if (e.Equals(first))
                        sb.Append(e.value.ToString());
                    else
                    {
                        sb.Append(e.value.ToString() + ",");
                        Show(e.prev, sb);
                    }
                }
            }
        }

        class Elements
        {
            public int value;
            public Elements next, prev;

            public Elements(int _value)
            {
                value = _value;
                next = prev = null;
            }
        }
    }
}
