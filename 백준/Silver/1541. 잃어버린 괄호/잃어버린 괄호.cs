using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj1541
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            string[] devided = sr.ReadLine().Split('-');
            sr.Close();
            int result = 0;
            for (int i = 0; i < devided.Length; i++)
            {
                foreach (string s in devided[i].Split('+'))
                {
                    if (i == 0)
                        result += int.Parse(s);
                    else
                        result -= int.Parse(s);
                }
            }
            Console.WriteLine(result);
        }
    }
}
