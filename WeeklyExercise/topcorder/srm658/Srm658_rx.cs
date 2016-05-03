using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13783
/// </summary>
namespace WeeklyExercise.topcorder.srm658
{

    class InfiniteString_rx
    {

        public String equal(String s, String t)
        {
            return "Equal";
        }



        public void doing()
        {

            print("Equal, " + equal("ab", "abab"));
            print("Not equal, " + equal("abc", "bca"));
            print("Not equal, " + equal("abab", "aba"));
            print("Equal, " + equal("aaaaa", "aaaaaa"));
            print("Equal, " + equal("ababab", "abab"));
            print("Not equal, " + equal("a", "z"));

        }

        public void print(String text)
        {
            Logger.log("return: " + text);
        }
    }

}
