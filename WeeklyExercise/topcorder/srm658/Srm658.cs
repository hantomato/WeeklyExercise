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

    class InfiniteString
    {

        public String equal(String s, String t)
        {
            // ababab, abab => abababababab
            long lcm = getLCM((long)s.Length, (long)t.Length);
            s = expand(s, lcm);
            t = expand(t, lcm);
            return s.Equals(t) ? "Equal" : "Not equal";
        }

        private String expand(String s, long newLen)
        {
            StringBuilder sb = new StringBuilder(s);
            while (sb.Length < newLen)
                sb.Append(s);
            return sb.ToString();
        }

        private long gcd(long a, long b)
        {
            while (b > 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private long getLCM(long a, long b)
        {
            return a * (b / gcd(a, b));
        }

        public void doing()
        {
            Console.WriteLine("Equal, " + equal("ab", "abab"));
            Console.WriteLine("Not equal, " + equal("abc", "bca"));
            Console.WriteLine("Not equal, " + equal("abab", "aba"));
            Console.WriteLine("Equal, " + equal("aaaaa", "aaaaaa"));
            Console.WriteLine("Equal, " + equal("ababab", "abab"));
            Console.WriteLine("Not equal, " + equal("a", "z"));
        }
    }

}
