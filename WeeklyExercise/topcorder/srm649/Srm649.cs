using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13658&rd=16313
///
/// </summary>
namespace WeeklyExercise.topcorder.srm649
{
    class DecipherabilityEasy
    {
        private String check(String s, String t)
        {
            if (s.Length != (t.Length + 1))
                return "Impossible";

            for (int i=0, minus=0; i<s.Length; ++i)
            {
                if (i < t.Length && s[i] != t[i - minus])
                {
                    ++minus;
                    if (minus == 2)
                        return "Impossible";
                }
            }

            return "Possible";
        }

        public void doing()
        {
            print(check("sunuke", "snuke"));
            print(check("snuke", "skue"));
            print(check("snuke", "snuke"));
            print(check("snukent", "snuke"));
            print(check("aaaaa", "aaaa"));
            print(check("aaaaa", "aaa"));
            print(check("topcoder", "tpcoder"));
            print(check("singleroundmatch", "singeroundmatc"));

            //result
            //Possible
            //Impossible
            //Impossible
            //Impossible
            //Possible
            //Impossible
            //Possible
            //Impossible

        }

        public void print(string text)
        {
            Logger.log("return: " + text);
        }
    }

}
