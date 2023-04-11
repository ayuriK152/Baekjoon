using System;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmStudy
{
    class boj1931
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(sr.ReadLine());
            Schedule[] schedules = new Schedule[n];
            int[] startTimes = new int[n];
            string[] input;
            for (int i = 0; i < n; i++)
            {
                input = sr.ReadLine().Split();
                schedules[i] = new Schedule(int.Parse(input[0]), int.Parse(input[1]));
                startTimes[i] = int.Parse(input[0]);
            }
            sr.Close();
            Array.Sort(schedules);

            int last = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (last > schedules[i].start)
                    continue;
                int start, end;
                start = schedules[i].start;
                end = schedules[i].end;
                for (int j = i + 1; j < n; j++)
                {
                    if (schedules[j].start > end)
                        break;
                    if (schedules[j].start >= start && schedules[j].start < end && schedules[j].end <= end)
                    {
                        start = schedules[j].start;
                        end = schedules[j].end;
                        i = j;
                    }
                }
                last = end;
                count++;
            }
            Console.WriteLine(count);
        }

        class Schedule : IComparable
        {
            public int start, end;
            public Schedule(int _start, int _end)
            {
                start = _start;
                end = _end;
            }

            public int CompareTo(object obj)
            {
                Schedule other = obj as Schedule;
                if (this.start == other.start)
                    return this.end.CompareTo(other.end);

                return this.start.CompareTo(other.start);
            }
        }
    }
}
