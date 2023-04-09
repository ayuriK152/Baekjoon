using System;

namespace AlgorithmStudy
{
    class boj1158
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split();
            int n = int.Parse(numbers[0]);
            int m = int.Parse(numbers[1]);
            node[] nodes = new node[n];
            for (int i = 0; i < n; i++)
                nodes[i] = new node();
            node tempNode = nodes[m - 1];

            Console.Write("<");
            while (true)
            {
                Console.Write($"{tempNode.nodeNum}");
                if (node.nodeCount == 1)
                    break;
                Console.Write(", ");
                tempNode = tempNode.next;
                node.RemoveNode(tempNode.prev);
                for (int j = 0; j < m - 1; j++)
                    tempNode = tempNode.next;
            }
            Console.Write(">");
        }

        class node
        {
            public static int nodeCount = 0;
            static node first;
            static node last;
            public int nodeNum;
            public node next = null;
            public node prev = null;
            public node()
            {
                AddNode(this);
                nodeCount++;
                nodeNum = nodeCount;
            }
            public static void AddNode(node n)
            {
                if (nodeCount == 0)
                {
                    n.next = n;
                    n.prev = n;
                    first = n;
                    last = n;
                }
                else
                {
                    n.next = first;
                    last.next = n;
                    first.prev = n;
                    n.prev = last;
                    last = n;
                }
            }

            public static void RemoveNode(node n)
            {
                n.next.prev = n.prev;
                n.prev.next = n.next;
                n.next = null;
                n.prev = null;
                nodeCount--;
            }
        }
    }
}
