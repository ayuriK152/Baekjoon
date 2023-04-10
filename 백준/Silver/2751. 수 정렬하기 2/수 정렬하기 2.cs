using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj10989
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            HeapSort(arr);
            foreach (int i in arr)
                sb.AppendLine(i.ToString());
            Console.WriteLine(sb);
        }

        static void HeapSort(int[] arr)
        {
            int[] heap = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                heap[i] = arr[i];
                int index = i;
                while (heap[index] < heap[(index - 1) / 2] && index != 0)
                {
                    int temp = heap[(index - 1) / 2];
                    heap[(index - 1) / 2] = heap[index];
                    heap[index] = temp;
                    index = (index - 1) / 2;
                }
            }

            int count = heap.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = heap[0];
                heap[0] = heap[count - 1];
                count--;
                int index = 0;
                while (index * 2 + 1 < count)
                {
                    if (index * 2 + 2 < count)
                    {
                        if (heap[index] <= heap[index * 2 + 1] && heap[index] <= heap[index * 2 + 2])
                            break;
                        index = heap[index * 2 + 1] > heap[index * 2 + 2] ? index * 2 + 2 : index * 2 + 1;
                    }
                    else
                    {
                        if (heap[index] <= heap[index * 2 + 1])
                            break;
                        index = index * 2 + 1;
                    }

                    int temp = heap[index];
                    heap[index] = heap[(index - 1) / 2];
                    heap[(index - 1) / 2] = temp;
                }
            }
        }
    }
}
