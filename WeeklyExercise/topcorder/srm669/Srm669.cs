using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13744
/// </summary>
namespace WeeklyExercise.topcorder.srm669
{

    class LiveConcert
    {
        
        int maxHappiness(int[] h, String[] s)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i=0; i<h.Length; ++i)
            {
                if (dic.ContainsKey(s[i]) && dic[s[i]] > h[i])
                    ;
                else
                {
                    dic[s[i]] = h[i];
                }
            }

            return dic.Sum(x => x.Value);
        }

        public void doing()
        {
            Console.WriteLine("23, " + maxHappiness(new int[] { 10,5,6,7,1,2}, new String[] { "ciel","bessie","john","bessie","bessie","john"}));
            Console.WriteLine("4, " + maxHappiness(new int[] { 3, 3, 4, 3, 3 }, new String[] { "a", "a", "a", "a", "a" }));
            Console.WriteLine("140, " + maxHappiness(new int[] {1,2,3,4,5,6,7,8,9,10,100}, 
                new String[] { "a", "b", "c", "d", "e", "e", "d", "c", "b", "a", "abcde" }));
            Console.WriteLine("100, " + maxHappiness(new int[] { 100 }, new String[] { "oyusop" } ));
            Console.WriteLine("1300, " + maxHappiness(new int[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 }, 
                new String[] {"haruka","chihaya","yayoi","iori","yukiho","makoto","ami","mami","azusa","miki","hibiki","takane","ritsuko"}));
        }
    }

}
