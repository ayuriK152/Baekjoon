using System;

namespace AlgorithmStudy
{
    class boj2529
    {
        static int k;
        static string[] sign;
        static bool[] check = new bool[10];
        public static void Main(string[] args)
        {
            k = int.Parse(Console.ReadLine());
            sign = new string[k];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < k; i++)
                sign[i] = input[i];

            Console.WriteLine(SearchDown(0, -1));
            for (int i = 0; i < 10; i++)
                check[i] = false;
            Console.WriteLine(SearchUp(0, -1));
        }

        static string SearchDown(int cnt, int num)
        {
            if (cnt == k)
                return num.ToString();
            for (int i = 9; i >= 0; i--)
            {
                if (check[i])
                    continue;
                if ((sign[cnt] == ">" && num > i) || (sign[cnt] == "<" && num < i) || num == -1)
                {
                    check[i] = true;
                    string temp;
                    if (num == -1) temp = SearchDown(cnt, i);
                    else temp = SearchDown(cnt + 1, i);
                    if (temp != "")
                    {
                        if (cnt + 1 == k) return $"{i}";
                        else return $"{i}{temp}";
                    }
                    check[i] = false;
                }
            }
            return "";
        }

        static string SearchUp(int cnt, int num)
        {
            if (cnt == k)
                return num.ToString();
            for (int i = 0; i < 10; i++)
            {
                if (check[i])
                    continue;
                if ((sign[cnt] == ">" && num > i) || (sign[cnt] == "<" && num < i) || num == -1)
                {
                    check[i] = true;
                    string temp;
                    if (num == -1) temp = SearchUp(cnt, i);
                    else temp = SearchUp(cnt + 1, i);
                    if (temp != "")
                    {
                        if (cnt + 1 == k) return $"{i}";
                        else return $"{i}{temp}";
                    }
                    check[i] = false;
                }
            }
            return "";
        }
    }
}
