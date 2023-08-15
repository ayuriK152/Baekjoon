using System;

namespace AlgorithmStudy
{
    class boj2615
    {
        static string[,] arr = new string[19, 19];
        public static void Main(string[] args)
        {
            for (int i = 0; i < 19; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 19; j++)
                    arr[j, i] = input[j];
            }

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (arr[j, i] != "0")
                    {
                        Pair startPoint = new Pair(j, i);
                        Search(startPoint, new Pair(1, 1));
                        Search(startPoint, new Pair(1, 0));
                        Search(startPoint, new Pair(1, -1));
                        Search(startPoint, new Pair(0, 1));
                        Search(startPoint, new Pair(0, -1));
                        Search(startPoint, new Pair(-1, 1));
                        Search(startPoint, new Pair(-1, 0));
                        Search(startPoint, new Pair(-1, -1));
                    }
                }
            }
            Console.WriteLine("0");
        }

        static void Search(Pair startPoint, Pair offset)
        {
            Pair endPoint = new Pair(startPoint.x + 4 * offset.x, startPoint.y + 4 * offset.y);
            if (endPoint.x < 0 || endPoint.x > 18 || endPoint.y < 0 || endPoint.y > 18)
                return;
            if (endPoint.x + offset.x >= 0 && endPoint.x + offset.x <= 18 && endPoint.y + offset.y >= 0 && endPoint.y + offset.y <= 18)
                if (arr[endPoint.x + offset.x, endPoint.y + offset.y] == arr[startPoint.x, startPoint.y])
                    return;
            if (startPoint.x - offset.x >= 0 && startPoint.x - offset.x <= 18 && startPoint.y - offset.y >= 0 && startPoint.y - offset.y <= 18)
                if (arr[startPoint.x - offset.x, startPoint.y - offset.y] == arr[startPoint.x, startPoint.y])
                    return;
            for (int i = 1; i < 5; i++)
            {
                if (arr[startPoint.x + i * offset.x, startPoint.y + i * offset.y] != arr[startPoint.x, startPoint.y])
                    return;
            }
            if (startPoint.x <= endPoint.x)
            {
                Console.WriteLine(arr[startPoint.x, startPoint.y]);
                Console.WriteLine($"{startPoint.y + 1} {startPoint.x + 1}");
            }
            else
            {
                Console.WriteLine(arr[endPoint.x, endPoint.y]);
                Console.WriteLine($"{endPoint.y + 1} {endPoint.x + 1}");
            }
            Environment.Exit(0);
        }

        public class Pair
        {
            public int x, y;

            public Pair(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
        }
    }
}
