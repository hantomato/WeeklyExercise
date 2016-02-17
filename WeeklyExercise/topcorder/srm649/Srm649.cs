using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13650&rd=16312
/// ex 1)
/// 150
/// 1050
/// 이라면. 
/// 
/// 1050 - (150 * 2의 0승 = 150) = 900    - first
/// 900  - (150 * 2의 1승 = 300) = 600    - second
/// 600  - (150 * 2의 2승 = 600) = 0.     - third
/// 총 3번 뺏으니, 3개 살수 있다.
/// 
/// ex 2)
/// 160
/// 163680
/// 이라면.
/// 
/// 163680 -    160 =   163520      first
/// 163520 -    320 =   163200      2
/// 163200 -    640 =   162560      3
/// 162560 -    1280 =  161280      4
/// 161280 -    2560 =  158720      5
///             5120  = 153600      6
///             10240 = 143360      7
///             20480 = 122880      8
///             40960 = 81920       9
///             81920 = 0           10
/// 즉 10개 살수 있다.
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
