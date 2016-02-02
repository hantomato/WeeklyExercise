using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13632&rd=16279
/// </summary>
namespace WeeklyExercise.topcorder.srm648
{
    class KitayutaMart2
    {
        public int numBought(int K, int T)
        {
            int idx;
            for (idx = 1; T > 0; ++idx)
                T -= ((int)Math.Pow(2, idx) * K);
            
            return idx - 1;
        }

        public void doing()
        {
            print(numBought(100, 100));
            print(numBought(100, 300));
            print(numBought(150, 1050));
            print(numBought(160, 163680));
            //1
            //2
            //3
            //10
        }

        public void print(int text)
        {
            Logger.log("return: " + text);
        }
    }

}
