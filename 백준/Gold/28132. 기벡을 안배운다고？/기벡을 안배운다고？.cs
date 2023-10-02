using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj28132
    {
        public static void Main(string[] args)
        {
            Dictionary<KeyValuePair<long, long>, int> dict = new Dictionary<KeyValuePair<long, long>, int>();
            int n = int.Parse(Console.ReadLine());
            KeyValuePair<long, long>[] vectors = new KeyValuePair<long, long>[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                long x = long.Parse(input[0]), y = long.Parse(input[1]);
                if (x != 0 && y != 0)
                {
                    long gcd = GCD(Math.Abs(x), Math.Abs(y));
                    x /= gcd;
                    y /= gcd;
                }
                else
                {
                    x = x == 0 ? 0 : x / Math.Abs(x);
                    y = y == 0 ? 0 : y / Math.Abs(y);
                }
                vectors[i] = new KeyValuePair<long, long>(x, y);
                if (!dict.ContainsKey(vectors[i]))
                    dict.Add(vectors[i], 0);
                dict[vectors[i]]++;
            }

            long count = 0;
            KeyValuePair<long, long> zeroVec = new KeyValuePair<long, long>(0, 0);
            for (int i = 0; i < n; i++)
            {
                if (vectors[i].Equals(zeroVec))
                {
                    count += n - i - 1;
                    dict[zeroVec]--;
                    continue;
                }
                KeyValuePair<long, long> reverseA = new KeyValuePair<long, long>(-vectors[i].Value, vectors[i].Key);
                KeyValuePair<long, long> reverseB = new KeyValuePair<long, long>(vectors[i].Value, -vectors[i].Key);
                if (dict.ContainsKey(reverseA))
                    count += dict[reverseA];
                if (dict.ContainsKey(reverseB))
                    count += dict[reverseB];
                if (dict.ContainsKey(zeroVec))
                    count += dict[zeroVec];
                dict[vectors[i]]--;
            }

            Console.Write(count);

            long GCD(long a, long b)
            {
                if (b % a == 0)
                    return a;
                return GCD(b % a, a);
            }
        }
    }
}
