using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13960
/// </summary>
namespace WeeklyExercise.topcorder.srm665_rx
{

    class LuckyXor
    {
        int[] lucky = { 4, 7, 44, 47, 74, 77 };

        int construct(int a)
        {
            var ret = lucky.Select(x => a ^ x)
                .Where(x => x > a && x < 100)
                .OrderBy(x => x);

            return ret.Count() == 0 ? -1 : ret.First();
        }

        public void doing()
        {
            Console.WriteLine("40, " + construct(4));
            Console.WriteLine("20, " + construct(19));
            Console.WriteLine("92, " + construct(88));
            Console.WriteLine("-1, " + construct(36));
        }
    }

}
