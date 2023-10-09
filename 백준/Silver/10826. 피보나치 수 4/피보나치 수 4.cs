using System;

namespace AlgorithmStudy
{
    class boj10826
    {
        public static void Main(string[] args)
        {
            string[] fib = new string[10001];
            fib[0] = "0";
            fib[1] = "1";
            fib[2] = "1";
            for (int i = 3; i < 10001; i++)
                fib[i] = BigSum(fib[i - 1], fib[i - 2]);

            int n = int.Parse(Console.ReadLine());

            Console.Write(fib[n]);

            string BigSum(string a, string b)
            {
                char[] result = a.ToCharArray();
                int aIndex = a.Length - 1;
                for (int bIndex = b.Length - 1; bIndex >= 0; bIndex--, aIndex--)
                    result[aIndex] += (char)(b[bIndex] - '0');
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    if (result[i] > '9')
                    {
                        if (i == 0)
                        {
                            char[] temp = new char[result.Length + 1];
                            temp[0] = '0';
                            result.CopyTo(temp, 1);
                            result = temp;
                            result[i]++;
                            result[i + 1] = (char)(result[i + 1] - 10);
                        }
                        else
                        {
                            result[i - 1]++;
                            result[i] = (char)(result[i] - 10);
                        }
                    }
                }
                return string.Concat(result);
            }
        }
    }
}
