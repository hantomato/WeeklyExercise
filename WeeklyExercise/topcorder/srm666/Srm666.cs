using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13744
/// </summary>
namespace WeeklyExercise.topcorder.srm666
{

    class DevuAndGame
    {

        String canWin(int[] nextLevel)
        {
            int cnt = 0;
            int idx = 0;
            while (true)
            {
                if (nextLevel[idx] == -1)
                    return "Win";

                if (++cnt > nextLevel.Length)
                    return "Lose";

                idx = nextLevel[idx];
            }
        }

        public void doing()
        {

            Console.WriteLine("Win, " + canWin(new int[] {1, -1}));
            Console.WriteLine("Lose, " + canWin(new int[] {1, 0, -1}));
            Console.WriteLine("Lose, " + canWin(new int[] {0, 1, 2}));
            Console.WriteLine("Win, " + canWin(new int[] {
                29,33,28,16,-1,11,10,14,6,31,7,35,34,8,15,17,26,12,13,22,1,20,2,21,-1,5,19,9,18,4,25,32,3,30,23,10,27}));
            Console.WriteLine("Win, " + canWin(new int[] {
                17,43,20,41,42,15,18,35,-1,31,7,33,23,33,-1,-1,0,33,19,12,42,-1,-1,9,9,-1,39,-1,31,46,-1,20,44,41,-1,-1,12,-1,36,-1,-1,6,47,10,2,4,1,29}));
            Console.WriteLine("Lose, " + canWin(new int[] {3, 1, 1, 2, -1, 4}));
        }
    }

}
