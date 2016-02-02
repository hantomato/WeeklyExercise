using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13650&rd=16312
/// </summary>
namespace WeeklyExercise.topcorder.srm648
{
    class KitayutaMart2_rx
    {
        public static IEnumerable<T> Unfold<T>(T seed, Func<T, T> accumulator)
        {
            var nextValue = seed;
            while (true)
            {
                yield return nextValue;
                nextValue = accumulator(nextValue);
            }
        }

        public int numBought(int K, int T)
        {
            var naturalNumbers = Unfold(K, i => i * 2);
            return naturalNumbers.ToObservable()
                .TakeWhile(x => x <= T)     // emit : 160, 320, 640 .. 81920 총 10개
                .Scan((x, y) => x + y)      // emit : 160, 480, 1120 .. 163680 총 10개
                .Where(x => x <= T)         // emit : 160, 480, 1120 .. 163680 총 10개
                .Count()                    //
                .First();
        }

        public void doing()
        {
            print(numBought(100, 100));
            print(numBought(100, 300));
            print(numBought(150, 1050));
            print(numBought(160, 163680));
            //1
            //2
            //3
            //10
        }

        public void print(int text)
        {
            Logger.log("return: " + text);
        }
    }

}
