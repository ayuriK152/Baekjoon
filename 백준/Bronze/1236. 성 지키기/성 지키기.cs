using System;

namespace AlgorithmStudy
{
    class boj1236
    {
        static public void Main(string[] args)
        {
            bool[] x, y;
            string input = Console.ReadLine();
            string[] numString = input.Split();
            int n = int.Parse(numString[0]);
            int m = int.Parse(numString[1]);
            x = new bool[n];
            y = new bool[m];

            for (int i = 0; i < n; i++)
            {
                string mat = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    if (mat[j] == 'X')
                    {
                        x[i] = true;
                        y[j] = true;
                    }
                }
            }

            int xTotal = n;
            int yTotal = m;

            foreach (bool i in x)
                if (i)
                    xTotal--;
            foreach (bool j in y)
                if (j)
                    yTotal--;
            if (xTotal > yTotal)
                Console.WriteLine($"{xTotal}");
            else
                Console.WriteLine($"{yTotal}");
        }
    }
}
