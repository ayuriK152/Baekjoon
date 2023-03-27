using System;

namespace AlgorithmStudy
{
    class boj1259
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                bool isPalindrome = true;
                string input = Console.ReadLine();
                if (input.Equals("0"))
                    break;
                else
                {
                    for (int i = 0; i < input.Length / 2; i++)
                    {
                        if (!input[i].Equals(input[input.Length - (1 + i)]))
                        {
                            isPalindrome = false;
                            break;
                        }
                    }
                    if (!isPalindrome)
                        Console.WriteLine("no");
                    else
                        Console.WriteLine("yes");
                }
            }
        }
    }
}