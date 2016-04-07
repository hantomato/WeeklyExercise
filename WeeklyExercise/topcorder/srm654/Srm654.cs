using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13700
/// </summary>
namespace WeeklyExercise.topcorder.srm654
{
    public class GroupOfAdjacent<TSource, TKey> : IEnumerable<TSource>, IGrouping<TKey, TSource>
    {
        public TKey Key { get; set; }
        private List<TSource> GroupList { get; set; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<TSource>)this).GetEnumerator();
        }
        System.Collections.Generic.IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
        {
            foreach (var s in GroupList)
                yield return s;
        }
        public GroupOfAdjacent(List<TSource> source, TKey key)
        {
            GroupList = source;
            Key = key;
        }
    }

    public static class LocalExtensions
    {
        public static IEnumerable<IGrouping<TKey, TSource>> GroupAdjacent<TSource, TKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector)
        {
            TKey last = default(TKey);
            bool haveLast = false;
            List<TSource> list = new List<TSource>();
            foreach (TSource s in source)
            {
                TKey k = keySelector(s);
                if (haveLast)
                {
                    if (!k.Equals(last))
                    {
                        yield return new GroupOfAdjacent<TSource, TKey>(list, last);
                        list = new List<TSource>();
                        list.Add(s);
                        last = k;
                    }
                    else
                    {
                        list.Add(s);
                        last = k;
                    }
                }
                else
                {
                    list.Add(s);
                    last = k;
                    haveLast = true;
                }
            }
            if (haveLast)
                yield return new GroupOfAdjacent<TSource, TKey>(list, last);
        }
    }

    class SquareScoresDiv2
    {

        public int getscore(String s)
        {
            return s.GroupAdjacent(x => x)          // [[zzz],[xx],[zz]]
                .Select (x => x.Count())            // [3,2,2]
                .Select (x => ((x + 1) * x) / 2)    // [6,3,3]
                .Aggregate((x, y) => x + y);        // 12
        }

        public void doing()
        {
            print("8, " + getscore("aaaba"));
            print("12, " + getscore("zzzxxzz"));
            print("26, " + getscore("abcdefghijklmnopqrstuvwxyz"));
            print("1, " + getscore("p"));
            print("5050, " + getscore("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
        }

        public void print(String text)
        {
            Logger.log("return: " + text);
        }
    }

}
