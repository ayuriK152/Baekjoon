using System;

namespace AlgorithmStudy
{
    class boj25206
    {
        public static void Main(string[] args)
        {
            double totalScore = 0, mulScore = 0;
            for (int i = 0; i < 20; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[2].Equals("P"))
                    continue;
                double score = double.Parse(input[1]);
                string grade = input[2];
                double gradeScore = 0.0;
                switch (grade)
                {
                    case "A+":
                        gradeScore = 4.5;
                        break;
                    case "A0":
                        gradeScore = 4.0;
                        break;
                    case "B+":
                        gradeScore = 3.5;
                        break;
                    case "B0":
                        gradeScore = 3.0;
                        break;
                    case "C+":
                        gradeScore = 2.5;
                        break;
                    case "C0":
                        gradeScore = 2.0;
                        break;
                    case "D+":
                        gradeScore = 1.5;
                        break;
                    case "D0":
                        gradeScore = 1.0;
                        break;
                }
                totalScore += score;
                mulScore += score * gradeScore;
            }
            double result = mulScore / totalScore;
            Console.WriteLine(result.ToString("0.000000"));
        }
    }
}
