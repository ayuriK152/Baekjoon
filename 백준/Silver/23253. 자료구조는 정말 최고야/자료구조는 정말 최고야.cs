using System;
using System.Collections;
using System.IO;

namespace AlgorithmStudy
{
    class boj23253
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            string[] input = sr.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            int[] index = new int[n];
            Stack[] books = new Stack[m];
            for (int i = 0; i < m; i++)
            {
                books[i] = new Stack();
                int mount = int.Parse(sr.ReadLine());
                input = sr.ReadLine().Split();
                for (int j = 0; j < mount; j++)
                {
                    index[int.Parse(input[j]) - 1] = i;
                    books[i].Push(int.Parse(input[j]));
                }
            }
            sr.Close();

            int current = 1;
            bool isPos = true;
            while (current <= n)
            {
                if ((int)books[index[current - 1]].Peek() == current)
                {
                    books[index[current - 1]].Pop();
                    current++;
                }
                else
                {
                    isPos = false;
                    Console.WriteLine("No");
                    break;
                }
            }
            if (isPos)
                Console.WriteLine("Yes");
        }
    }
}
