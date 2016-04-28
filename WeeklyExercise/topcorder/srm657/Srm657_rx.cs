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

    class EightRooks_rx
    {

        public String isCorrect(String[] board)
        {
            int[][] newBoard = Convert(board);

            int res = newBoard.ToObservable()
                .Select(x => x.Aggregate((a, b) => a + b))     // [1,0,0,0,0,0,0,0] --> [1]
                .Where(x => x != 1)
                .Count()
                .First();

            //if (res == 0)
            //{ 
            //    return "Correct";
            //} else
            //{
            //    return "Incorrect";
            //}
            //newBoard[0].Zip(newBoard[1], (x, y) => x + y)
            //    .Select(x =>
            //    {
            //        return x;
            //    });


            //Observable.Zip(newBoard[0], newBoard[1], newBoard[2], (x, y) => x + y);
            //var aaa = newBoard[0].Zip(newBoard[1], this.sum);
            //aaa.Zip(newBoard[2], (x, y) => x + y);

            //IEnumerable<int> temp = null;
            //for (int i=0; i<7; ++i)
            //{
            //    temp = newBoard[i].Zip(newBoard[i+1], this.sum);
            //}

            //foreach ( int a in aaa)
            //{
            //    Console.WriteLine(a);
            //}


            //.Subscribe(z =>
            //{
            //    Console.WriteLine(z);
            //});
            //newBoard.ToObservable()
            //    .Zip()

            return "";
        }

        public int sum(int x, int y)
        {
            return x + y;
        }

        private int[][] Convert(String[] board)
        {
            // 2차 배열로 변환
            int[][] newBoard = new int[board.Length][];
            for (int i = 0; i < board.Length; ++i)
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


        public void doing()
        {

            int[] aaa = new int[] { 1, 2, 3, 4, 5 };
            int ii = aaa.Aggregate((x, y) => x + y);

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

            //print("Incorrect, " + isCorrect(new String[]
            //{
            //    "........",
            //    "....R...",
            //    "........",
            //    ".R......",
            //    "........",
            //    "........",
            //    "..R.....",
            //    "........"
            //}));

            //print("Correct, " + isCorrect(new String[]
            //    {"......R.",
            //     "....R...",
            //     "...R....",
            //     ".R......",
            //     "R.......",
            //     ".....R..",
            //     "..R.....",
            //     ".......R"}
            //));


            //print("Incorrect, " + isCorrect(new String[]
            //    {"......R.",
            //     "....R...",
            //     "...R....",
            //     ".R......",
            //     "R.......",
            //     ".......R",
            //     "..R.....",
            //     ".......R"}
            //));

            //print("Incorrect, " + isCorrect(new String[]
            //    {"........",
            //     "........",
            //     "........",
            //     "........",
            //     "........",
            //     "........",
            //     "........",
            //     "........"}
            //));

        }

        public void print(String text)
        {
            Logger.log("return: " + text);
        }
    }

}
