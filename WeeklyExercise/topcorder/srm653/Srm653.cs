using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13678
/// </summary>
namespace WeeklyExercise.topcorder.srm652
{
    class CountryGroup
    {
        // ex) 2*4 + 1*2 + 2*4 + 3*5 + 1*2 = 35
        public int solve(int[] a)
        {

            //
            return 0;
        }

        public void doing()
        {
            print(solve(new int[] { 2, 2, 3, 3, 3 }));
            print(solve(new int[] { 1, 1, 1, 1, 1 }));
            print(solve(new int[] { 3, 3 }));
            print(solve(new int[] { 4, 4, 4, 4, 1, 1, 2, 2, 3, 3, 3 }));
            print(solve(new int[] { 2, 1, 2, 2, 1, 2 }));
        }

        public void print(int text)
        {
            Logger.log("return: " + text);
        }
    }

}
