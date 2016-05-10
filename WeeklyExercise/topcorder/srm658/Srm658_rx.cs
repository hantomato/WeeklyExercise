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
            // ababab, abab => abababababab
            int lcm = (int)getLCM((long)s.Length, (long)t.Length);
            String s1 = s.ToObservable()
                .Repeat()
                .Take(lcm)
                .Aggregate("", (x, y) => x + y)
                .First();

            String t1 = t.ToObservable()
                .Repeat()
                .Take(lcm)
                .Aggregate("", (x, y) => x + y)
                .First();

            return s1.Equals(t1) ? "Equal" : "Not equal";
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
