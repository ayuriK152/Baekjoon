using System;
using System.Collections;
using System.Globalization;
using System.IO;

namespace AlgorithmStudy
{
    class boj1697
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            Queue queue = new Queue();
            bool[] check = new bool[200001];
            string[] input = sr.ReadLine().Split();
            int n = int.Parse(input[0]), k = int.Parse(input[1]);
            sr.Close();

            queue.Enqueue(n);

            int count = 0;
            int layer = 1;
            while (true)
            {
                int temp = (int)queue.Dequeue();
                if (temp == k)
                    break;
                if (temp + 1 == k || temp - 1 == k || temp * 2 == k)
                {
                    count++;
                    break;
                }
                if (temp < k)
                {
                    if (!check[temp + 1])
                    {
                        queue.Enqueue(temp + 1);
                        check[temp + 1] = true;
                    }
                    if (!check[temp * 2])
                    {
                        queue.Enqueue(temp * 2);
                        check[temp * 2] = true;
                    }
                }
                if (temp > 0)
                {
                    if (!check[temp - 1])
                    {
                        queue.Enqueue(temp - 1);
                        check[temp - 1] = true;
                    }
                }
                layer--;
                if (layer == 0)
                {
                    layer = queue.Count;
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
