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
    class ValueOfString_rx
    {
        // ex) 2*4 + 1*2 + 2*4 + 3*5 + 1*2 = 35
        public static IEnumerable<T> Unfold<T>(T seed, Func<T, T> accumulator)
        {
            var nextValue = seed;
            while (true)
            {
                yield return nextValue;
                nextValue = accumulator(nextValue);
            }
        }

        public int findValue(String s)
        {
            return 0;
        }

        public void doing()
        {
            print(findValue("babca"));
            print(findValue("zz"));
            print(findValue("y"));
            print(findValue("aaabbc"));
            print(findValue("topcoder"));
            print(findValue("thequickbrownfoxjumpsoverthelazydog"));
            print(findValue("zyxwvutsrqponmlkjihgfedcba"));
        }

        public void print(int text)
        {
            Logger.log("return: " + text);
        }
    }

}
