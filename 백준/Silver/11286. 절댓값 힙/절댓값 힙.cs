using System;
using System.IO;
using System.Text;

namespace AlgorithmStudy
{
    class boj11286
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            MinHeap heap = new MinHeap();
            int n = int.Parse(sr.ReadLine());
            int input;
            for (int i = 0; i < n; i++)
            {
                input = int.Parse(sr.ReadLine());
                if (input.Equals(0))
                    sb.AppendLine(heap.Pop().ToString());
                else
                    heap.Add(input);
            }
            sw.Write(sb.ToString());
            sw.Close();
            sr.Close();
        }

        class MinHeap
        {
            int[] arr = new int[100000];
            int count;

            public MinHeap()
            {
                count = 0;
            }

            public void Add(int n)
            {
                arr[count] = n;
                if (count != 0)
                {
                    int current = count;
                    while ((Math.Abs(arr[current]) < Math.Abs(arr[(current - 1) / 2]) ||
                        (Math.Abs(arr[current]) == Math.Abs(arr[(current - 1) / 2]) &&
                        arr[current] < 0)) && current != 0)
                    {
                        int temp = arr[current];
                        arr[current] = arr[(current - 1) / 2];
                        arr[(current - 1) / 2] = temp;
                        current = (current - 1) / 2;
                    }
                }
                count++;
            }

            public int Pop()
            {
                if (count == 0)
                    return 0;
                int ret = arr[0];
                arr[0] = arr[count - 1];
                count--;

                int current = 0;
                while ((current + 1) * 2 - 1 < count)
                {
                    if ((current + 1) * 2 >= count)
                    {
                        current = (current + 1) * 2 - 1;
                        if (Math.Abs(arr[current]) > Math.Abs(arr[(current - 1) / 2]))
                            break;
                        else
                        {
                            if (Math.Abs(arr[current]) < Math.Abs(arr[(current - 1) / 2]) || (Math.Abs(arr[current]) == Math.Abs(arr[(current - 1) / 2]) && arr[current] < 0))
                            {
                                int temp = arr[current];
                                arr[current] = arr[(current - 1) / 2];
                                arr[(current - 1) / 2] = temp;
                            }
                        }
                    }
                    else
                    {
                        if (Math.Abs(arr[(current + 1) * 2 - 1]) != Math.Abs(arr[(current + 1) * 2]))
                            current = Math.Abs(arr[(current + 1) * 2 - 1]) > Math.Abs(arr[(current + 1) * 2]) ? (current + 1) * 2 : (current + 1) * 2 - 1;
                        else
                            current = arr[(current + 1) * 2 - 1] > arr[(current + 1) * 2] ? (current + 1) * 2 : (current + 1) * 2 - 1;
                        if (Math.Abs(arr[current]) > Math.Abs(arr[(current - 1) / 2]))
                            break;
                        else
                        {
                            if (Math.Abs(arr[current]) < Math.Abs(arr[(current - 1) / 2]) || (Math.Abs(arr[current]) == Math.Abs(arr[(current - 1) / 2]) && arr[current] < 0))
                            {
                                int temp = arr[current];
                                arr[current] = arr[(current - 1) / 2];
                                arr[(current - 1) / 2] = temp;
                            }
                        }
                    }
                }

                return ret;
            }
        }
    }
}
