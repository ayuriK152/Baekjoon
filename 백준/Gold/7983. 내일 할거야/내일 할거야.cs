using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj7983
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Pair> pairs = new List<Pair>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                pairs.Add(new Pair(int.Parse(input[0]), int.Parse(input[1])));
            }
            pairs.Sort();

            int remain = pairs[0].t;
            for (int i = 0; i < n; i++)
            {
                int diff = remain - pairs[i].t;
                remain -= diff > 0 ? diff : 0 ;
                remain -= pairs[i].d;
            }
            Console.WriteLine(remain);
        }

        class Pair : IComparable<Pair>
        {
            public int d, t;

            public Pair(int _d, int _t)
            {
                d = _d;
                t = _t;
            }

            public int CompareTo(Pair other)
            {
                return -t.CompareTo(other.t);
            }
        }
    }
}
