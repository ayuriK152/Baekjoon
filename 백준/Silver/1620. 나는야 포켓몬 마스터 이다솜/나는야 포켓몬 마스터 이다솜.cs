using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj1620
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StringBuilder sb = new StringBuilder();
            Hashtable names = new Hashtable();
            string[] temp = sr.ReadLine().Split();
            int n = int.Parse(temp[0]), m = int.Parse(temp[1]);
            string[] namesByIndex = new string[n];
            string input;

            for (int i = 0; i < n; i++)
            {
                input = sr.ReadLine();
                names.Add(input, i + 1);
                namesByIndex[i] = input;
            }
            for (int i = 0; i < m; i++)
            {
                input = sr.ReadLine();
                int index;
                if (int.TryParse(input, out index))
                    sb.Append(namesByIndex[index - 1]);
                else
                    sb.Append(names[input]);
                Console.WriteLine(sb);
                sb.Clear();
            }
            sr.Close();
        }
    }
}
