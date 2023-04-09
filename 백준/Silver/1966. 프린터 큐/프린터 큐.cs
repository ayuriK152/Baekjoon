using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace AlgorithmStudy
{
    class boj1966
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int t = int.Parse(sr.ReadLine());
            string[] input;
            for (int i = 0; i < t; i++)
            {
                Queue queue = new Queue();
                input = sr.ReadLine().Split();
                int n = int.Parse(input[0]), m = int.Parse(input[1]);
                object[] docs = new object[n];

                input = sr.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    docs[j] = int.Parse(input[j]);
                    queue.Enqueue(docs[j]);
                }

                object target = docs[m];
                int count = 0;
                while (queue.Count > 0)
                {
                    if ((int)queue.Peek() >= (int)queue.ToArray().Max())
                    {
                        count++;
                        if (queue.Dequeue() == target)
                            break;
                    }
                    else
                        queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine(count);
            }
        }
    }
}
