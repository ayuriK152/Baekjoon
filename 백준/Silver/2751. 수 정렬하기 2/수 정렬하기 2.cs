using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj2751
    {
        static int[] temp = new int[1000000];
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            MergeSort(arr, 0, n - 1);
            foreach (int i in arr)
                sb.AppendLine(i.ToString());
            Console.WriteLine(sb);
        }

        static void MergeSort(int[] arr, int left, int right)
        {
            if (left == right) return;
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            int pivotL = left, pivotR = mid + 1, current = 0;
            while (pivotL <= mid && pivotR <= right)
                temp[current++] = arr[pivotL] <= arr[pivotR] ? arr[pivotL++] : arr[pivotR++];
            if (pivotL > mid)
                for (int i = pivotR; i <= right; i++)
                    temp[current++] = arr[i];
            else
                for (int i = pivotL; i <= mid; i++)
                    temp[current++] = arr[i];
            for (int i = 0; i < current; i++)
                arr[i + left] = temp[i];
            return;
        }
    }
}