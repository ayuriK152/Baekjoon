using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AlgorithmStudy
{
    class boj1011
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StringBuilder sb = new StringBuilder();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            MinHeap heap = new MinHeap();
            int n = int.Parse(sr.ReadLine());
            int[] nums = new int[n];
            string[] input = sr.ReadLine().Split();
            sr.Close();
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(input[i]);
                if (!dic.Keys.Contains(nums[i]))
                {
                    dic.Add(nums[i], 0);
                    heap.Add(nums[i]);
                }
            }
            for (int i = 0; i < dic.Count; i++)
                dic[heap.Pop()] = i;
            foreach (int num in nums)
                sb.Append(dic[num] + " ");
            Console.WriteLine(sb);
        }

        class MinHeap
        {
            int[] elements;
            int count;

            public MinHeap()
            {
                elements = new int[1000000];
                count = 0;
            }

            public void Add(int n)
            {
                if (count == 0)
                    elements[count++] = n;
                else
                {
                    elements[count] = n;
                    int current = count;
                    while (elements[(current - 1) / 2] > elements[current])
                    {
                        int temp = elements[current];
                        elements[current] = elements[(current - 1) / 2];
                        elements[(current - 1) / 2] = temp;
                        current = (current - 1) / 2;
                    }
                    count++;
                }
            }

            public int Pop()
            {
                int ret = elements[0];
                count--;
                elements[0] = elements[count];
                int current = 0;

                while ((current + 1) * 2 - 1 < count)
                {
                    if ((current + 1) * 2 >= count)
                    {
                        current = (current + 1) * 2 - 1;
                        if (elements[current] < elements[(current - 1) / 2])
                        {
                            int temp = elements[current];
                            elements[current] = elements[(current - 1) / 2];
                            elements[(current - 1) / 2] = temp;
                        }
                        else
                            break;
                    }

                    else
                    {
                        current = elements[(current + 1) * 2 - 1] > elements[(current + 1) * 2] ? (current + 1) * 2 : (current + 1) * 2 - 1;
                        if (elements[current] < elements[(current - 1) / 2])
                        {
                            int temp = elements[current];
                            elements[current] = elements[(current - 1) / 2];
                            elements[(current - 1) / 2] = temp;
                        }
                        else
                            break;
                    }
                }
                return ret;
            }
        }
    }
}
