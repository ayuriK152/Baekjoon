using System;
using System.Collections;
using System.Linq;

namespace AlgorithmStudy
{
    class boj1107
    {
        public static void Main(string[] args)
        {
            Queue cards = new Queue();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                cards.Enqueue(i);
            while (true)
            {
                if (cards.Count == 1)
                    break;
                cards.Dequeue();
                cards.Enqueue((int)cards.Dequeue());
            }
            Console.WriteLine(cards.Dequeue());
        }
    }
}