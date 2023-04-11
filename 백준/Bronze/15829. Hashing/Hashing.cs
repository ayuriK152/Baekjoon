using System;
using System.IO;

namespace AlgorithmStudy
{
    class boj15829
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            ulong m = 1234567891;
            int l = int.Parse(sr.ReadLine());
            string s = sr.ReadLine();
            int result = 0;
            ulong temp;
            sr.Close();
            for (int i = 0; i < l; i++)
            {
                temp = (ulong)s[i] - 'a' + 1;
                for (int j = 0; j < i; j++)
                    temp = (temp * 31) % m;
                result += (int)temp;
            }
            Console.WriteLine(result);
        }
    }
}
