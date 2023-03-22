using System;

namespace AlgorithmStudy
{
    public enum Register
    {
        black,
        brown,
        red,
        orange,
        yellow,
        green,
        blue,
        violet,
        grey,
        white,
        none
    }

    class boj1076
    {
        static public void Main(string[] args)
        {
            Int64 total = 0;
            Register r = Register.none;

            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "black":
                        r = Register.black;
                        break;
                    case "brown":
                        r = Register.brown;
                        break;
                    case "red":
                        r = Register.red;
                        break;
                    case "orange":
                        r = Register.orange;
                        break;
                    case "yellow":
                        r = Register.yellow;
                        break;
                    case "green":
                        r = Register.green;
                        break;
                    case "blue":
                        r = Register.blue;
                        break;
                    case "violet":
                        r = Register.violet;
                        break;
                    case "grey":
                        r = Register.grey;
                        break;
                    case "white":
                        r = Register.white;
                        break;
                }
                if (i == 2)
                    total *= (int)Math.Pow(10, (int)r);
                else
                    total += (int)Math.Pow(10, 1 - i) * (int)r;
            }

            Console.WriteLine($"{total}");
        }
    }
}
