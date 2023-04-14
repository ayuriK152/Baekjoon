using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj12873
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(sr.ReadLine());
            sr.Close();
            CircularQueue queue = new CircularQueue();

            for (int i = 0; i < n; i++)
                queue.Add();
            int count = 1;
            while (true)
            {
                if (!queue.RemoveAtFrom(queue.first, (long)Math.Pow(count, 3) % queue.count))
                    break;
                count++;
            }
            Console.WriteLine(queue.first.value);
        }

        class CircularQueue
        {
            public int count;
            public Elements first, last;

            public CircularQueue()
            {
                count = 0;
                first = last = null;
            }

            public void Add()
            {
                count++;
                Elements temp = new Elements(count);
                if (count == 1)
                {
                    temp.prev = temp;
                    temp.next = temp;
                    first = last = temp;
                }
                else
                {
                    last.next = temp;
                    temp.prev = last;
                    last = temp;
                    last.next = first;
                    first.prev = last;
                }
            }

            public bool RemoveAtFrom(Elements e, long index)
            {
                if (count == 1)
                    return false;
                if (index == 0)
                    Remove(e.prev);
                else if (index == 1)
                    Remove(e);
                else
                    RemoveAtFrom(e.next, index - 1);
                return true;
            }

            public void Remove(Elements e)
            {
                count--;
                e.next.prev = e.prev;
                e.prev.next = e.next;
                first = e.next;
                last = e.prev;
                e.next = e.prev = null;
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
