using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13773
/// 8 x 8 오목판 같은게 있는데, 가로, 세로로 돌이 2개가 놓여질수 없는 규칙을 지키면서
/// 돌을 8개를 놓아야함.
/// </summary>
namespace WeeklyExercise.topcorder.srm657
{

    class EightRooks
    {

        public String isCorrect(String[] board)
        {
            int [][] newBoard = Convert(board);
            int[] rowMerged = Merge(newBoard, 0);
            int[] colMerged = Merge(newBoard, 1);

            if (Check(rowMerged) && Check(colMerged))
            {
                return "Correct";
            }
            return "Incorrect";
        }

        private int[][] Convert(String[] board)
        {
            // 2차 배열로 변환
            int[][] newBoard = new int[board.Length][];
            for (int i=0; i<board.Length; ++i)
            {
                newBoard[i] = new int[board[i].Length];
                for (int m = 0; m < board[i].Length; ++m)
                {
                    if (board[i][m] == 'R')
                        newBoard[i][m] = board[i][m] == 'R' ? 1 : 0;
                }
            }
            return newBoard;
        }

        private int[] Merge(int[][] board, int opt)
        {
            if (opt == 0)
            {
                int[] res = new int[board.Length];
                for (int r=0; r<board.Length; ++r)
                {
                    for (int c=0; c<board[r].Length; ++c)
                    {
                        res[r] += board[r][c];
                    }
                }
                return res;
            } else
            {
                int[] res = new int[board[0].Length];
                for (int c=0; c<board[0].Length; ++c)
                {
                    for (int r=0; r<board.Length; ++r)
                    {
                        res[c] += board[r][c];
                    }
                }
                return res;
            }

        }

        private Boolean Check(int[] result)
        {

            foreach(int n in result)
            {
                if (n != 1)
                    return false;
            }
            return true;

        }


        public void doing()
        {



            print("Correct, " + isCorrect(new String[]
            {
                "R.......",
                ".R......",
                "..R.....",
                "...R....",
                "....R...",
                ".....R..",
                "......R.",
                ".......R"
            }));

            print("Incorrect, " + isCorrect(new String[]
            {
                "........",
                "....R...",
                "........",
                ".R......",
                "........",
                "........",
                "..R.....",
                "........"
            }));

            print("Correct, " + isCorrect(new String[]
                {"......R.",
                 "....R...",
                 "...R....",
                 ".R......",
                 "R.......",
                 ".....R..",
                 "..R.....",
                 ".......R"}
            ));


            print("Incorrect, " + isCorrect(new String[]
                {"......R.",
                 "....R...",
                 "...R....",
                 ".R......",
                 "R.......",
                 ".......R",
                 "..R.....",
                 ".......R"}
            ));

            print("Incorrect, " + isCorrect(new String[]
                {"........",
                 "........",
                 "........",
                 "........",
                 "........",
                 "........",
                 "........",
                 "........"}
            ));

        }

        public void print(String text)
        {
            Logger.log("return: " + text);
        }
    }

}
