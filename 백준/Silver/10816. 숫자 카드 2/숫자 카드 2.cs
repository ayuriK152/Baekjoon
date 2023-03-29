using System;
using System.Text;
using System.Collections;

namespace AlgorithmStudy
{
    class boj10816
    {
        public static void Main(string[] args)
        {
            Hashtable count = new Hashtable();
            int cardMount = int.Parse(Console.ReadLine());
            string[] cards = Console.ReadLine().Split();
            for (int i = 0; i < cardMount; i++)
            {
                if (!count.ContainsKey(cards[i]))
                    count.Add(cards[i], 1);
                else
                {
                    int temp = (int)count[cards[i]];
                    temp++;
                    count[cards[i]] = temp;
                }
            }

            int checkMount = int.Parse(Console.ReadLine());
            string[] checks = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < checkMount; i++)
            {
                if (!count.ContainsKey(checks[i]))
                    result.Append("0 ");
                else
                    result.Append(count[checks[i]] + " ");
            }
            Console.WriteLine(result);
        }
    }
}