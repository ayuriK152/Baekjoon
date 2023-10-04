using System;

namespace AlgorithmStudy
{
    class boj14266
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Pos[] pos = new Pos[n * 2];
            for (int i = 0; i < pos.Length; i += 2)
            {
                string[] input = Console.ReadLine().Split(' ');
                pos[i] = new Pos(long.Parse(input[0]), long.Parse(input[1]), true);
                pos[i + 1] = new Pos(long.Parse(input[2]), long.Parse(input[3]), false);
                if (pos[i].CompareTo(pos[i + 1]) > 0)
                {
                    pos[i].isInit = false;
                    pos[i + 1].isInit = true;
                }
            }
            Array.Sort(pos);

            int count = 0, max = 0;
            for (int i = 0; i < pos.Length; i++)
            {
                if (pos[i].isInit)
                    count++;
                else
                    count--;
                max = count > max ? count : max;
            }

            Console.Write(max);
        }

        class Pos : IComparable<Pos>
        {
            public long x, y;
            public bool isInit;
            public Pos(long _x, long _y, bool _isInit)
            {
                x = _x;
                y = _y;
                isInit = _isInit;
            }

            public int CompareTo(Pos other)
            {
                return -(y / (double)x).CompareTo(other.y / (double)other.x);
            }
        }
    }
}
