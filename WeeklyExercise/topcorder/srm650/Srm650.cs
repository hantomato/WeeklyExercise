using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13650&rd=16312
/// </summary>
namespace WeeklyExercise.topcorder.srm650
{
    class TaroJiroDividing
    {

        public int getNumber(int A, int B)
        {
            int min = Math.Min(A, B);
            int max = Math.Max(A, B);
            // 큰수가 작은수의 배수라면
            if ((max % min) == 0)
                return _getNumber(min, 1);

            return 0;
        }

        public int _getNumber(int A, int idx)
        {
            if ((A % 2) != 0)
                return idx;

            return _getNumber(A / 2, ++idx);
        }

        public void doing()
        {
            print(getNumber(8, 4));
            print(getNumber(4, 7));
            print(getNumber(12, 12));
            print(getNumber(24, 96));
            print(getNumber(1000000000, 999999999));
            //result
            //3
            //0
            //3
            //4
            //0
        }

        public void print(int text)
        {
            Logger.log("return: " + text);
        }
    }

}
