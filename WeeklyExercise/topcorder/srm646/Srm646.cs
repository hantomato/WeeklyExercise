using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13626&rd=16278
/// </summary>
namespace WeeklyExercise.topcorder.srm646
{
    class TheConsecutiveIntegersDivTwo
    {
        public static int find(int[] numbers, int k)
        {
            if (k == 1) return 0;

            int res = 100000;
            Array.Sort(numbers);
            for (int i=0; i<numbers.Length - 1; ++i)
            {
                res = Math.Min(res, numbers[i + 1] - numbers[i]);
            }
            return res - 1;
        }

        public void doing()
        {
            print(find(new int[] { 4, 47, 7 }, 2));
            print(find(new int[] {1, 100}, 1));
            print(find(new int[] { -96, -53, 82, -24, 6, -75 }, 2));
            print(find(new int[] { 64, -31, -56 }, 2));
            //return: 2
            //return: 1
            //return: 20
            //return: 24
        }

        public void print(int n)
        {
            Logger.log("return: " + n);
        }
    }
}
