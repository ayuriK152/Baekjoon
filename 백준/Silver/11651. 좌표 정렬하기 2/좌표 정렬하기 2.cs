using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj11651
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int n = int.Parse(sr.ReadLine());
            PosPair[] pos = new PosPair[n];
            string[] input;
            for (int i = 0; i < n; i++)
            {
                input = sr.ReadLine().Split();
                pos[i] = new PosPair(int.Parse(input[0]), int.Parse(input[1]));
            }
            sr.Close();
            Array.Sort(pos);
            foreach (PosPair p in pos)
                sw.WriteLine(p.x + " " + p.y);
            sw.Close();
        }

        class PosPair : IComparable
        {
            public int x, y;

            public PosPair(int _x, int _y)
            {
                x = _x;
                y = _y;
            }

            public int CompareTo(object obj)
            {
                PosPair other = (PosPair)obj;
                if (this.y == other.y)
                    return this.x.CompareTo(other.x);
                return this.y.CompareTo(other.y);
            }
        }
    }
}
