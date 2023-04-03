using System;

namespace AlgorithmStudy
{
    class boj2605
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Student[] s = new Student[n];
            string[] temp = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
                if (i == 0)
                    s[i] = new Student(int.Parse(temp[i]), true);
                else
                    s[i] = new Student(int.Parse(temp[i]), false, s[Student.lastIndex]);
            Console.WriteLine(Student.ShowAll(s[Student.lastIndex]));
        }
        class Student
        {
            static int count = 0;
            public static int lastIndex;
            public int id;
            Student next;
            bool isLast;
            public Student(int _num, bool _isLast, Student _next = null)
            {
                id = 1 + count++;
                next = _next;
                isLast = _isLast;
                Add(next, null, _num);
            }

            void Add(Student _next, Student _prev, int _num)
            {
                if (_num == 0)
                {
                    next = _next;
                    if (_prev != null)
                        _prev.next = this;
                    if (_next != null)
                        if (_next.isLast)
                        {
                            _next.isLast = false;
                            isLast = true;
                            lastIndex = id - 1;
                        }
                }
                else
                {
                    Add(_next.next, _next, _num - 1);
                }
            }

            public static string ShowAll(Student s)
            {
                if (s.next == null)
                    return s.id.ToString();
                return ShowAll(s.next) + " " + s.id;
            }
        }
    }
}