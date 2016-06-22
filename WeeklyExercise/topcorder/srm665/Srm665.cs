using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13960
/// </summary>
namespace WeeklyExercise.topcorder.srm665
{

    class LuckyXor
    {
        int[] lucky = { 4, 7, 44, 47, 74, 77 };

        int construct(int a)
        {
            List<int> temp = new List<int>();
            for(int n=0; n<lucky.Length; ++n)
            {
                int value = a ^ lucky[n];
                if (value > a && value < 100)
                    temp.Add(value);
            }

            if (temp.Count() == 0)
                return -1;

            temp.Sort();
            return temp[0];
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
