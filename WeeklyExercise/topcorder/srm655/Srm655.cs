using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13700
/// </summary>
namespace WeeklyExercise.topcorder.srm655
{

    class BichromeBoard
    {

        public String ableToDraw(String[] board)
        {
            char first = figureOutStartItem(board);
            if (first == 'i')
                return "Impossible";

            return checkBoard(first, board);
        }

        private char figureOutStartItem(String[] board)
        {
            for (int r = 0; r < board.Length; ++r)
            {
                String text = board[r];
                for (int c = 0; c < text.Length; ++c)
                {
                    if (text[c] != '?')
                        return _figureOutStartItem(r, c, text[c]);
                }
            }
            return 'I';
        }

        private char _figureOutStartItem(int r, int c, char a)
        {
            if (r % 2 == 1)
                a = change(a);
            if (c % 2 == 1)
                a = change(a);
            return a;
        }

        private char change(char a)
        {
            return a == 'B' ? 'W' : 'B';
        }

        private String checkBoard(char first, String[] board)
        {
            char reverseFirst = change(first);
            for (int r = 0; r < board.Length; ++r)
            {
                String text = board[r];
                for (int c = 0; c < text.Length; ++c)
                {
                    if ((r + c) % 2 == 0)
                    {
                        if (text[c] == reverseFirst)
                            return "Impossible";
                    } else
                    {
                        if (text[c] == first)
                            return "Impossible";
                    }
                }
            }
            return "Possible";
        }

        public void doing()
        {
            print("Possible, "      + ableToDraw(new String[] {"W?W", "??B", "???"}));
            print("Impossible, "    + ableToDraw(new String[] {"W??W"}));
            print("Possible, "      + ableToDraw(new String[] {"??"}));
            print("Possible, "      + ableToDraw(new String[] {"W???", "??B?", "W???", "???W"}));
            print("Impossible, "    + ableToDraw(new String[] {"W???", "??B?", "W???", "?B?W"}));
            print("Possible, "      + ableToDraw(new String[] {"B"}));
        }

        public void print(String text)
        {
            Logger.log("return: " + text);
        }
    }

}
