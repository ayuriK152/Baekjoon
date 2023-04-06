using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Linq.Expressions;

namespace AlgorithmStudy
{
    class boj1021
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int n = int.Parse(temp[0]), m = int.Parse(temp[1]);
            Node[] nodes = new Node[n];
            for (int i = 0; i < n; i++)
                nodes[i] = new Node();
            temp = Console.ReadLine().Split();
            int[] targets = new int[m];
            for (int i = 0; i < m; i++)
                targets[i] = int.Parse(temp[i]);
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                count += Node.first.SearchCount(targets[i]);
                Node.Remove(Node.first);
            }

            Console.WriteLine(count);
        }
        class Node
        {
            public static int count = 0;
            public static Node first;
            public static Node last;
            int value;
            Node next;
            Node prev;
            
            public Node()
            {
                value = count + 1;
                if (count == 0)
                {
                    next = this;
                    prev = this;
                    first = this;
                    last = this;
                }
                else
                {
                    next = first;
                    first.prev = this;
                    prev = last;
                    prev.next = this;
                    last = this;
                }
                count++;
            }

            static public void Remove(Node n)
            {
                if (first.Equals(n))
                    first = n.next;
                n.next.prev = n.prev;
                n.prev.next = n.next;
                n.next = null;
                n.prev = null;
                count--;
            }

            public int SearchCount(int n)
            {
                if (value == n)
                    return 0;
                else
                {
                    int nextCnt = next.SearchCountNext(n) + 1;
                    int prevCnt = prev.SearchCountPrev(n) + 1;
                    return Math.Min(nextCnt, prevCnt);
                }
            }

            int SearchCountNext(int n)
            {
                if (value == n)
                    return 0;
                else
                    return next.SearchCountNext(n) + 1;
            }

            int SearchCountPrev(int n)
            {
                if (value == n)
                {
                    first = this;
                    last = this.prev;
                    return 0;
                }
                else
                    return prev.SearchCountPrev(n) + 1;
            }
        }
    }
}