using System;
using System.Text;

namespace AlgorithmStudy
{
    class boj1343
    {
        public static void Main(string[] args)
        {
            string[] board = Console.ReadLine().Split('.');
            StringBuilder sb = new StringBuilder();
            bool flag = true;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i].Length % 2 != 0)
                {
                    flag = false;
                    break;
                }
                int aCnt = board[i].Length / 4, bCnt = (board[i].Length % 4) / 2;
                for (int j = 0; j < aCnt; j++)
                    sb.Append("AAAA");
                if (bCnt == 1)
                    sb.Append("BB");
                sb.Append(".");
            }
            if (!flag)
                Console.WriteLine("-1");
            else
            {
            sb.Remove(sb.Length - 1, 1);
                Console.WriteLine(sb);
            }
        }
    }
}
