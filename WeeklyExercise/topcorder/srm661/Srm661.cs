using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13768
/// </summary>
namespace WeeklyExercise.topcorder.srm661
{
    static class Ext
    {
        public static IEnumerable<IEnumerable<T>> Transpose<T>(
                 this IEnumerable<IEnumerable<T>> source)
        {
            return from row in source
                   from col in row.Select(
                       (x, i) => new KeyValuePair<int, T>(i, x))
                   group col.Value by col.Key into c
                   select c as IEnumerable<T>;
        }

        public static String FallingSandSort(this String src)
        {
            String[] splited = src.Split(new char[] { 'x' });
            String ret = splited.Select(x => x.OrderBy(a => a))
                .Aggregate("", (x, y) =>
                {
                    return new String(x.ToArray()) + new String(y.ToArray()) + "x";
                });

            if (ret.Length > src.Length)
            {
                ret = ret.Substring(0, ret.Length - 1);
            }
            return ret;
        }
    }
    class FallingSand
    {


        String[] simulate(String[] board)
        {
            var temp = board.Transpose().Select(x => new String(x.ToArray()).FallingSandSort());

            // 다시 transpose 후 String[]로 변환
            return temp.Transpose()
                .Select(x => new String(x.ToArray()))
                .ToArray();
        }

        public void doing()
        {
            PrintArray(simulate(new String[] { "ooooo", "..x..", "....x", ".....", "....o" }));
            PrintArray(simulate(new String[] { "..o..", "..x.o", "....x", ".....", "oo.oo" }));
            PrintArray(simulate(new String[] { "ooooxooo.ooxo.oxoxoooox.....x.oo" }));
            PrintArray(simulate(new String[] { "o", ".", "o", ".", "o", ".", "." }));
            PrintArray(simulate(new String[] { "oxxxxooo", "xooooxxx", "..xx.ooo", "oooox.o.", "..x....." }));
            PrintArray(simulate(new String[]{
                "..o..o..o..o..o..o..o..o..o..o..o",
                "o..o..o..o..o..o..o..o..o..o..o..",
                ".o..o..o..o..o..o..o..o..o..o..o.",
                "...xxx...xxx...xxxxxxxxx...xxx...",
                "...xxx...xxx...xxxxxxxxx...xxx...",
                "...xxx...xxx......xxx......xxx...",
                "...xxxxxxxxx......xxx......xxx...",
                "...xxxxxxxxx......xxx......xxx...",
                "...xxxxxxxxx......xxx......xxx...",
                "...xxx...xxx......xxx............",
                "...xxx...xxx...xxxxxxxxx...xxx...",
                "...xxx...xxx...xxxxxxxxx...xxx...",
                "..o..o..o..o..o..o..o..o..o..o..o",
                "o..o..o..o..o..o..o..o..o..o..o..",
                ".o..o..o..o..o..o..o..o..o..o..o."}));
        }

        private void PrintArray(String[] param)
        {
            foreach(String item in param)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    }

}
