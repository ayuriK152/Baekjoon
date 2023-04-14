using System;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmStudy
{
    class boj1107
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int target = int.Parse(sr.ReadLine());
            int targetLen = target.ToString().Length;
            List<int> enableNums = new List<int>();
            for (int i = 0; i < 10; i++)
                enableNums.Add(i);
            int m = int.Parse(sr.ReadLine());
            if (m == 0)
                Console.WriteLine(Math.Min(targetLen, Math.Abs(target - 100)));
            else
            {
                string[] temp = sr.ReadLine().Split();
                for (int i = 0; i < m; i++)
                    enableNums.Remove(int.Parse(temp[i]));
                if (m == 10)
                    Console.WriteLine(Math.Abs(target - 100));
                else
                {
                    int lowNum = 0, lowNumCount = 0;
                    List<int> lowNumIndex = new List<int>();
                    for (int i = 0; i < targetLen; i++)
                    {
                        lowNumIndex.Add(enableNums.Count - 1);
                        lowNum += enableNums[lowNumIndex[i]] * (int)Math.Pow(10, i);
                    }
                    while (lowNum > target)
                    {
                        int carryCount = 0;
                        for (int i = 0; i <= carryCount; i++)
                        {
                            if (lowNumIndex[i] == 0)
                            {
                                if (i == lowNumIndex.Count - 1)
                                    lowNumIndex.RemoveAt(i);
                                else
                                {
                                    carryCount++;
                                    lowNumIndex[i] = enableNums.Count - 1;
                                }
                            }
                            else
                                lowNumIndex[i]--;
                        }

                        lowNum = 0;
                        for (int i = 0; i < lowNumIndex.Count; i++)
                            lowNum += enableNums[lowNumIndex[i]] * (int)Math.Pow(10, i);
                    }
                    lowNumCount += (target - lowNum) + lowNum.ToString().Length;

                    int highNum = 0, highNumCount = 0;
                    if (enableNums.Count == 1 && enableNums[0] == 0)
                        highNumCount = lowNumCount;
                    else
                    {
                        List<int> highNumIndex = new List<int>();
                        for (int i = 0; i < targetLen; i++)
                        {
                            highNumIndex.Add(0);
                            highNum += enableNums[0] * (int)Math.Pow(10, i);
                        }
                        while (highNum < target)
                        {
                            int carryCount = 0;
                            for (int i = 0; i <= carryCount; i++)
                            {
                                if (highNumIndex[i] == enableNums.Count - 1)
                                {
                                    if (i == highNumIndex.Count - 1)
                                        highNumIndex.Add(0);
                                    else
                                    {
                                        carryCount++;
                                        highNumIndex[i] = 0;
                                    }
                                }
                                else
                                    highNumIndex[i]++;
                            }

                            highNum = 0;
                            for (int i = 0; i < highNumIndex.Count; i++)
                                highNum += enableNums[highNumIndex[i]] * (int)Math.Pow(10, i);
                        }
                        highNumCount += (highNum - target) + highNumIndex.Count;
                    }
                    if (lowNumIndex.Count == 0)
                        Console.WriteLine(Math.Min(Math.Abs(target - 100), highNumCount));
                    else
                        Console.WriteLine(Math.Min(Math.Abs(target - 100), Math.Min(lowNumCount, highNumCount)));
                }
            }
            sr.Close();
        }
    }
}
