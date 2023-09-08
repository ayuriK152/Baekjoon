using System;
using static System.Console;

namespace AlgorithmStudy
{
    internal class boj10101
    {
        public static void Main(string[] args)
        {
            int[] angles = new int[3];
            for (int i = 0; i < 3; i++)
                angles[i] = int.Parse(ReadLine());
            if (angles[0] + angles[1] + angles[2] != 180)
                WriteLine("Error");
            else if (angles[0] == angles[1] && angles[1] == angles[2])
                WriteLine("Equilateral");
            else if (angles[0] == angles[1] || angles[1] == angles[2] || angles[0] == angles[2])
                WriteLine("Isosceles");
            else
                WriteLine("Scalene");
        }
    }
}
